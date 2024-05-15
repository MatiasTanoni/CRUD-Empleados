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
        private void CambiarColor(TextBox textBox, Label label, PictureBox pictureBox)
        {

            if (textBox.Text.Length != 0)
            {
                pictureBox.BackColor = Color.Black;
                label.ForeColor = Color.Black;
            }
            else
            {
                pictureBox.BackColor = Color.Red;
                label.ForeColor = Color.Red;
            }
        }
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

                        foreach (Usuario usuario in usuarios)
                        {
                            if (usuario.Correo == textBoxCorreo.Text && usuario.Clave == textContrasena.Text)
                            {
                                FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
                            }
                            else
                            {
                                MessageBox.Show("Error ha ingresado mal el usuario!");
                            }
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

        private void labelContrasena_Click(object sender, EventArgs e)
        {

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
