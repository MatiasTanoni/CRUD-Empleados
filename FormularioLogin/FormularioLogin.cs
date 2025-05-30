﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Entidades;


namespace Formularios
{
    public partial class FormularioLogin : Form
    {
        /// <summary>
        /// Usuario registrado en el formulario de inicio de sesión.
        /// </summary>
        private Usuario usuarioRegistrado = new Usuario();
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
        /// 
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
            string jsonPathAbsoluto= "C:\\Users\\Matías Tanoni\\OneDrive\\Escritorio\\Parcial\\Tanoni.Matias\\datosLogin.json";
            string jsonPath = ObtenerRutaRelativa(jsonPathAbsoluto);
            
            if (File.Exists(jsonPath))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(jsonPath, Encoding.UTF8, true))
                    {
                        string jsonString = streamReader.ReadToEnd();

                        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString);

                        bool usuarioEncontrado = false;
                        foreach (Usuario usuario in usuarios)
                        {
                            if (usuario.Correo == textBoxCorreo.Text && usuario.Clave == textContrasena.Text)
                            {
                                UsuarioRegistrado = usuario;
                                usuarioEncontrado = true;
                                RegistrarAccesoUsuario();
                                FormularioPrincipal formularioPrincipal = new FormularioPrincipal(this.UsuarioRegistrado);
                                formularioPrincipal.ShowDialog();
                                break;
                            }
                        }
                        if (!usuarioEncontrado)
                        {
                            MessageBox.Show("Error, ha ingresado mal el usuario o la contraseña.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer/deserializar el archivo JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("El archivo JSON no existe.");
            }

        }
        /// <summary>
        /// Registra el acceso del usuario en un archivo de registro.
        /// </summary>
        private void RegistrarAccesoUsuario()
        {

            string rutaAbsoluta = @"C:\Users\Matías Tanoni\OneDrive\Escritorio\Parcial\Tanoni.Matias\usuarios.log";
            string rutaRelativa = ObtenerRutaRelativa(rutaAbsoluta);

            string fechaHoraActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string informacionUsuario = $"Apellido: {usuarioRegistrado.Apellido} " +
                                        $"Usuario: {usuarioRegistrado.Nombre}," +
                                        $"Legajo:{usuarioRegistrado.Legajo}," +
                                        $"Correo:{usuarioRegistrado.Correo}, " +
                                        $"Clave:{usuarioRegistrado.Clave}, " +
                                        $"Perfil: {usuarioRegistrado.Perfil} " +
                                        $"Fecha y Hora de Acceso: {fechaHoraActual}";

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaRelativa, true))
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
        /// Obtiene la ruta relativa a partir de una ruta absoluta.
        /// </summary>
        /// <param name="rutaAbsoluta">La ruta absoluta a convertir en relativa.</param>
        /// <returns>La ruta relativa correspondiente.</returns>
        private string ObtenerRutaRelativa(string rutaAbsoluta)
        {
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;

            Uri uriArchivo = new Uri(rutaAbsoluta);
            Uri uriDirectorioBase = new Uri(directorioBase);

            Uri uriRelativa = uriDirectorioBase.MakeRelativeUri(uriArchivo);
            string rutaRelativa = Uri.UnescapeDataString(uriRelativa.ToString());

            rutaRelativa = rutaRelativa.Replace('/', '\\');

            return rutaRelativa;
        }

    }
}
