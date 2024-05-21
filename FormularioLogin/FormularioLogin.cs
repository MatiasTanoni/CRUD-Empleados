using System;
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
using FormularioLogin;


namespace Formularios
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(textBoxCorreo, labelCorreo, pictureBoxBorderCorreo);
        }
        private void textContrasena_TextChanged(object sender, EventArgs e)
        {
            CambiarColor(textContrasena, labelContrasena, pictureBoxBorderContrasena);

        }
        //private void pictureBoxIniciarSesion_Click(object sender, EventArgs e)
        //{
        //    CambiarColorIniciarSesion(textContrasena,textBoxCorreo,pictureBoxIniciarSesion);
        //}
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
        //private void CambiarColorIniciarSesion(TextBox textBoxContrasena,TextBox textBoxCorreo,PictureBox pictureBox)
        //{
        //    if (textBoxContrasena.Text.Length != 0 && textBoxCorreo.Text.Length != 0)
        //    {
        //        pictureBox.BackColor = Color.Green;
        //    }
        //    else { pictureBox.BackColor = Color.Black;}
        //}
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string jsonPath = "C:\\Users\\Matías Tanoni\\OneDrive\\Escritorio\\Parcial\\Tanoni.Matias\\datosLogin.json";

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
                                usuarioEncontrado = true;
                                FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
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

    }
}
