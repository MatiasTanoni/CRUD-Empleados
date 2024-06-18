using Entidades;

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
            if (!int.TryParse(textBox.Text, out _))
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    empleado.Nombre = textBox.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para el Nombre");
                    return false;
                }  
            }
            else
            {
                MessageBox.Show("Por favor, el nombre no puede ser un número.");
                return false;
            }
        }
        public bool ValidarEdad(Empleado empleado, TextBox textBox)
        {

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (int.TryParse(textBox.Text, out int edad))
                {

                if (edad >= 18 && edad < 65)
                {
                    empleado.Edad = edad;
                    return true;
                }
                else if (edad >= 65)
                {
                    MessageBox.Show("Por favor, No puede trabajar aquí porque tienes edad de jubilación, solo permitimos (18 a 64) años.");
                    return false;
                }
                else if (edad <= 18)
                {
                    MessageBox.Show("Por favor, No puede trabajar aquí porque eres menor de edad, solo permitimos (18 a 64) años.");
                    return false;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una edad válida (entre 18 y 64).");
                    return false;
                }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para la Edad.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para la Edad");
                return false;
            }


        }
        public bool ValidarExperiencia(Empleado empleado, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (int.TryParse(textBox.Text, out int experiencia))
                {
                    if (experiencia >= 0 && experiencia <= 45)
                    {
                        empleado.Experiencia = experiencia;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una experiencia válida (entre 0 y 45).");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para la Experiencia.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para la Experiencia");
                return false;
            }

        }
        public bool ValidarSalario(Empleado empleado, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (int.TryParse(textBox.Text, out int salario))
                {
                    if (salario > 0)
                    {
                        empleado.Salario = salario;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor numérico mayor a 0 para el Salario.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para el Salario.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para el Salario");
                return false;
            }

        }
    }
}
