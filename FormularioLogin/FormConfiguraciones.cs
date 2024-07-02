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

        /// <summary>
        /// Configura las propiedades del formulario actual para centrarlo en la pantalla,
        /// establecer el borde fijo y deshabilitar los botones de maximizar y minimizar.
        /// </summary>
        private void ConfigurarFormulario()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        /// <summary>
        /// Valida y asigna el nombre de un empleado desde un control TextBox.
        /// Si el nombre es válido (no es un número y no está vacío), lo asigna al empleado y devuelve true.
        /// Si el nombre es un número, lanza una excepción personalizada y muestra un mensaje de error.
        /// Si el TextBox está vacío, muestra un mensaje de error indicando que no puede estar vacío.
        /// </summary>
        public bool ValidarNombre(Empleado empleado, TextBox textBox)
        {
            try
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
                    throw new MiExcepcionPersonalizada("Por favor, el nombre no puede ser un número.");
                }
            }
            catch (MiExcepcionPersonalizada ex) 
            { 
                MessageBox.Show(ex.Message);
                return false ;
            }
        }

        /// <summary>
        /// Valida y asigna la edad de un empleado desde un control TextBox.
        /// Si la edad es válida (entre 18 y 64 años), la asigna al empleado y devuelve true.
        /// Si la edad no está dentro del rango válido, muestra un mensaje de error correspondiente y devuelve false.
        /// Si el TextBox está vacío, lanza una excepción personalizada y muestra un mensaje de error.
        /// </summary>
        /// <param name="empleado">Instancia del empleado a la que se asignará la edad válida.</param>
        /// <param name="textBox">Control TextBox que contiene la edad a validar.</param>
        /// <returns>True si la edad es válida y se asigna correctamente al empleado, de lo contrario false.</returns>
        public bool ValidarEdad(Empleado empleado, TextBox textBox)
        {
            try
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
                    throw new MiExcepcionPersonalizada("Por favor, No puede estar vacio, ingrese un valor para la Edad");
                }
            }
            catch (MiExcepcionPersonalizada ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Valida y asigna la experiencia de un empleado desde un control TextBox.
        /// Si la experiencia es válida (entre 0 y 45 años), la asigna al empleado y devuelve true.
        /// Si la experiencia no está dentro del rango válido, muestra un mensaje de error correspondiente y devuelve false.
        /// Si el TextBox está vacío, lanza una excepción personalizada y muestra un mensaje de error.
        /// </summary>
        /// <param name="empleado">Instancia del empleado a la que se asignará la experiencia válida.</param>
        /// <param name="textBox">Control TextBox que contiene la experiencia a validar.</param>
        /// <returns>True si la experiencia es válida y se asigna correctamente al empleado, de lo contrario false.</returns>
        public bool ValidarExperiencia(Empleado empleado, TextBox textBox)
        {
            try
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
                    throw new MiExcepcionPersonalizada("Por favor, No puede estar vacio, ingrese un valor para la Experiencia");
                }
            }
            catch (MiExcepcionPersonalizada ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Valida y asigna el salario de un empleado desde un control TextBox.
        /// Si el salario es válido (mayor a 0), lo asigna al empleado y devuelve true.
        /// Si el salario no es mayor a 0, muestra un mensaje de error correspondiente y devuelve false.
        /// Si el TextBox está vacío, lanza una excepción personalizada y muestra un mensaje de error.
        /// </summary>
        /// <param name="empleado">Instancia del empleado a la que se asignará el salario válido.</param>
        /// <param name="textBox">Control TextBox que contiene el salario a validar.</param>
        /// <returns>True si el salario es válido y se asigna correctamente al empleado, de lo contrario false.</returns>
        public bool ValidarSalario(Empleado empleado, TextBox textBox)
        {
            try
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
                    throw new MiExcepcionPersonalizada("Por favor, No puede estar vacio, ingrese un valor para el Salario");
                }
            }
            catch (MiExcepcionPersonalizada ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
