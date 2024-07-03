using Entidades;
using System.Text;
using System.Text.Json;

namespace Formularios
{
    public partial class FormularioLogin : FormConfiguraciones
    {
        /// <summary>
        /// Usuario registrado en el formulario de inicio de sesión.
        /// </summary>
        private Usuario usuarioRegistrado = new Usuario();
        private bool bandera = true;

        public FormularioLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Usuario registrado en el formulario de inicio de sesión.
        /// </summary>
        public Usuario UsuarioRegistrado
        {
            get { return usuarioRegistrado; }
            set { usuarioRegistrado = value; }
        }

        /// <summary>
        /// Maneja el evento TextChanged del TextBox para el correo electrónico.
        /// Cambia el color del borde y la etiqueta asociados.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(textBoxCorreo, labelCorreo, pictureBoxBorderCorreo);
        }

        /// <summary>
        /// Maneja el evento TextChanged del TextBox para la contraseña.
        /// Cambia el color del borde y la etiqueta asociados.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void textContrasena_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(textContrasena, labelContrasena, pictureBoxBorderContrasena);
        }

        /// <summary>
        /// Cambia el color de fondo del PictureBox y el color de la etiqueta en función del contenido del TextBox.
        /// </summary>
        /// <param name="textBox">El TextBox que se está evaluando.</param>
        /// <param name="label">La etiqueta asociada al TextBox.</param>
        /// <param name="pictureBox">El PictureBox asociado al TextBox.</param>
        private void CambiarColor(TextBox textBox, Label label, PictureBox pictureBox)
        {
            if (textBox.Text.Length != 0)
            {
                pictureBox.BackColor = Color.Green;
                label.ForeColor = Color.Green;
            }
            else
            {
                pictureBox.BackColor = Color.Black;
                label.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón de inicio de sesión.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string jsonPath = "datosLogin.json";
            Thread loginThread = new Thread(() => ProcesarLogin(jsonPath));
            loginThread.IsBackground = true;
            loginThread.Start();
            //labelStatus.Text = "Status: Verifying...";
        }

        /// <summary>
        /// Procesa el inicio de sesión basado en la información almacenada en un archivo JSON.
        /// </summary>
        /// <param name="jsonPath">Ruta del archivo JSON que contiene la información de los usuarios.</param>
        private void ProcesarLogin(string jsonPath)
        {
            if (File.Exists(jsonPath))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(jsonPath, Encoding.UTF8, true))
                    {
                        string jsonString = streamReader.ReadToEnd();

                        List<Usuario> usuarios;
                        if (jsonString != null)
                        {
                            var resultado = JsonSerializer.Deserialize<List<Usuario>>(jsonString);

                            if (resultado != null)
                            {
                                usuarios = resultado;
                            }
                            else
                            {
                                usuarios = new List<Usuario>();
                            }
                        }
                        else
                        {
                            usuarios = new List<Usuario>();
                        }

                        if (usuarios == null || usuarios.Count == 0)
                        {
                            MostrarMensaje("No hay usuarios registrados.");
                        }
                        else
                        {
                            bool usuarioEncontrado = false;
                            bool contrasenaCorrecta = false;

                            foreach (Usuario usuario in usuarios)
                            {
                                if (usuario.Correo == textBoxCorreo.Text)
                                {
                                    usuarioEncontrado = true;

                                    if (usuario.Clave == textContrasena.Text)
                                    {
                                        UsuarioRegistrado = usuario;
                                        RegistrarAccesoUsuario();
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            this.Hide();
                                            FormularioPrincipal formularioPrincipal = new FormularioPrincipal(this.UsuarioRegistrado);
                                            formularioPrincipal.ShowDialog();
                                        });
                                        contrasenaCorrecta = true;
                                        break;
                                    }
                                }
                            }
                            if (!usuarioEncontrado)
                            {
                                MostrarMensaje("Error, ha ingresado mal el correo.");
                            }
                            else if (!contrasenaCorrecta)
                            {
                                MostrarMensaje("Error, ha ingresado mal la contraseña.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensaje($"Error al leer/deserializar el archivo JSON: {ex.Message}");
                }
            }
            else
            {
                MostrarMensaje("El archivo JSON no existe.");
            }
        }

        /// <summary>
        /// Muestra un mensaje en forma de cuadro de diálogo MessageBox de forma segura en aplicaciones multi-hilo.
        /// </summary>
        /// <param name="mensaje">Mensaje que se desea mostrar.</param>
        private void MostrarMensaje(string mensaje)
        {
            this.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show(mensaje);
            });
        }

        /// <summary>
        /// Registra el acceso del usuario en un archivo de registro.
        /// </summary>
        private void RegistrarAccesoUsuario()
        {
            string ruta = @"usuarios.log";
            string fechaHoraActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string informacionUsuario = $"Apellido: {usuarioRegistrado.Apellido} " +
                                        $"Usuario: {usuarioRegistrado.Nombre}, " +
                                        $"Legajo: {usuarioRegistrado.Legajo}, " +
                                        $"Correo: {usuarioRegistrado.Correo}, " +
                                        $"Clave: {usuarioRegistrado.Clave}, " +
                                        $"Perfil: {usuarioRegistrado.Perfil} " +
                                        $"Fecha y Hora de Acceso: {fechaHoraActual}";

            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine(informacionUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el acceso del usuario: {ex.Message}");
            }
        }

        /// <summary>
        /// Alterna la visibilidad de la contraseña en el campo de texto de contraseña entre oculto y visible.
        /// </summary>
        private void buttonContraseña_Click(object sender, EventArgs e)
        {
            bandera = !bandera;
            if (bandera)
            {
                textContrasena.PasswordChar = '*';
                pictureBoxOjito.Image = Properties.Resources.ojitocerrado;
            }
            else
            {
                textContrasena.PasswordChar = '\0';
                pictureBoxOjito.Image = Properties.Resources.ojito;
            }
        }
    }
}