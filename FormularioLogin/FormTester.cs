using ADO;
using Entidades;

namespace Formularios
{
    public partial class FormTester : FormConfiguraciones
    {
        private Tester tester = new Tester();
        public Empresa empresa = new Empresa();
        private bool banderaModificar = false;

        /// <summary>
        /// Obtiene o establece el objeto de tipo Tester asociado a esta instancia.
        /// </summary>
        public Tester Tester
        {
            get { return tester; }
            set { tester = value; }
        }

        public FormTester()
        {
            InitializeComponent();
            empresa = new Empresa();
            empresa.ListaDeEmpleados = new List<Empleado>(); 
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormTester con la empresa proporcionada.
        /// </summary>
        /// <param name="empresa">La empresa asociada a este formulario.</param>
        public FormTester(Empresa empresa) : this()
        {
            this.empresa = empresa;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormTester con el objeto Tester proporcionado.
        /// Asigna los valores del objeto Tester a los controles del formulario.
        /// </summary>
        /// <param name="tester">El objeto Tester utilizado para inicializar el formulario.</param>
        public FormTester(Tester tester) : this()
        {
            this.tester = tester;
            this.textBoxNombre.Text = tester.Nombre.ToString();
            this.textBoxEdad.Text = tester.Edad.ToString();
            this.textBoxExperiencia.Text = tester.Experiencia.ToString();
            this.textBoxSalario.Text = tester.Salario.ToString();
            this.textBoxHerramientaDePrueba.Text = tester.HerramientaDePrueba.ToString();
            this.textBoxProyectosTesteados.Text = tester.ProyectosTesteados.ToString();
            banderaModificar = true;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Cancelar".
        /// Establece el resultado del diálogo como Cancelar.
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Aceptar".
        /// Valida los datos del formulario y agrega un nuevo objeto Tester a la lista de empleados si los datos son válidos.
        /// </summary>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            bool esValido = true;
            esValido &= Validar(tester, "nombre", textBoxNombre);
            esValido &= Validar(tester, "edad", textBoxEdad);
            esValido &= Validar(tester, "experiencia", textBoxExperiencia);
            esValido &= Validar(tester, "salario", textBoxSalario);
            esValido &= Validar(tester, "herramienta de prueba", textBoxHerramientaDePrueba);
            esValido &= Validar(tester, "proyectos testeados", textBoxProyectosTesteados);

            if (esValido)
            {
                if (FormularioPrincipal.abrirBD)
                {
                    if (banderaModificar == false)
                    {
                        Datos.AgregarEmpleado(textBoxNombre.Text, int.Parse(textBoxEdad.Text), int.Parse(textBoxExperiencia.Text), int.Parse(textBoxSalario.Text), textBoxHerramientaDePrueba.Text,TipoDeEmpleados.Tester, int.Parse(textBoxProyectosTesteados.Text));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Datos.ModificarEmpleado(textBoxNombre.Text, int.Parse(textBoxEdad.Text), int.Parse(textBoxExperiencia.Text), int.Parse(textBoxSalario.Text), textBoxHerramientaDePrueba.Text, TipoDeEmpleados.Tester, int.Parse(textBoxProyectosTesteados.Text), tester.Id);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.empresa != tester)
                    {
                        tester.Tipo = TipoDeEmpleados.Tester;
                        this.empresa += tester;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        /// <summary>
        /// Valida los datos de un objeto Tester según el tipo de dato especificado.
        /// </summary>
        /// <param name="tester">El objeto Tester a validar.</param>
        /// <param name="dato">El tipo de dato a validar (nombre, herramienta de prueba, edad, salario, experiencia, proyectos testeados).</param>
        /// <param name="textBox">El control TextBox que contiene el valor a validar.</param>
        /// <returns>True si los datos son válidos; False si no lo son.</returns>
        private bool Validar(Tester tester, string dato, TextBox textBox)
        {
            switch (dato)
            {
                case "nombre":
                    return ValidarNombre(tester, textBox);
                case "herramienta de prueba":
                    return ValidarHerramientaDePrueba(tester, textBox);
                case "edad":
                    return ValidarEdad(tester, textBox);
                case "salario":
                    return ValidarSalario(tester, textBox);
                case "experiencia":
                    return ValidarExperiencia(tester, textBox);
                case "proyectos testeados":
                    return ValidarProyetosTesteados(tester, textBox);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Valida el valor ingresado en el TextBox para la herramienta de prueba del Tester.
        /// Si el valor no es numérico, lo asigna al Tester y retorna verdadero; de lo contrario, muestra un mensaje de error y retorna falso.
        /// Si el TextBox está vacío, muestra un mensaje de error y retorna falso.
        /// </summary>
        /// <param name="tester">El objeto Tester al que se asignará la herramienta de prueba.</param>
        /// <param name="textBox">El TextBox que contiene el valor de la herramienta de prueba.</param>
        /// <returns>Verdadero si la validación es exitosa y se asigna la herramienta de prueba al Tester; de lo contrario, falso.</returns>
        private bool ValidarHerramientaDePrueba(Tester tester, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    tester.HerramientaDePrueba = textBox.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, La HerramientaDePrueba no puede ser un número.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para la Herramienta De Prueba.");
                return false;
            }
        }

        /// <summary>
        /// Valida el valor ingresado en el TextBox para los proyectos testeados del Tester.
        /// Si el valor es numérico, lo asigna al Tester y retorna verdadero; de lo contrario, muestra un mensaje de error y retorna falso.
        /// Si el TextBox está vacío, muestra un mensaje de error y retorna falso.
        /// </summary>
        /// <param name="tester">El objeto Tester al que se asignarán los proyectos testeados.</param>
        /// <param name="textBox">El TextBox que contiene el valor de los proyectos testeados.</param>
        /// <returns>Verdadero si la validación es exitosa y se asignan los proyectos testeados al Tester; de lo contrario, falso.</returns>
        private bool ValidarProyetosTesteados(Tester tester, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (int.TryParse(textBox.Text, out int ProyectosTesteados))
                {
                    tester.ProyectosTesteados = ProyectosTesteados;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para los proyectos testeados.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para los proyectos testeados.");
                return false;
            }
        }
    }
}

