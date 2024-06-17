using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormConfiguraciones : Form
    {
        public FormConfiguraciones()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public bool ValidarNombre(Empleado empleado, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !int.TryParse(textBox.Text, out _))
            {
                empleado.Nombre = textBox.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, el nombre no puede estar vacío o ser un número.");
                return false;
            }
        }
        public bool ValidarEdad(Empleado empleado, TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int edad))
            {
                if (edad > 0 && edad < 65)
                {
                    empleado.Edad = edad;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una edad válida (entre 1 y 64).");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la edad.");
                return false;
            }
        }
        public bool ValidarExperiencia(Empleado empleado, TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int experiencia))
            {
                if (experiencia >= 0 && experiencia <= 40)
                {
                    empleado.Experiencia = experiencia;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una experiencia válida (entre 0 y 40).");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la experiencia.");
                return false;
            }
        }
    }
}
