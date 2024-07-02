using Entidades;
using TextBox = System.Windows.Forms.TextBox;
using ADO;

namespace Formularios
{
    public partial class FormDesarrollador : FormConfiguraciones
    {
        private bool banderaModificar = false;
        private Desarrollador desarrollador = new Desarrollador();

        /// <summary>
        /// Representa una empresa que contiene una lista de empleados.
        /// </summary>
        public Empresa empresa = new Empresa();

        /// <summary>
        /// Obtiene o establece el objeto Desarrollador asociado.
        /// </summary>
        public Desarrollador Desarrollador
        {
            get { return desarrollador; }
            set { desarrollador = value; }
        }

        public FormDesarrollador()
        {
            InitializeComponent();
            empresa = new Empresa();
            empresa.ListaDeEmpleados = new List<Empleado>();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormDesarrollador con la empresa especificada.
        /// </summary>
        /// <param name="empresa">La empresa asociada al formulario.</param>
        public FormDesarrollador(Empresa empresa) : this()
        {
            this.empresa = empresa;
            banderaModificar = false;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormDesarrollador con el desarrollador especificado.
        /// </summary>
        /// <param name="desarrollador">El desarrollador asociado al formulario.</param>
        public FormDesarrollador(Desarrollador desarrollador) : this()
        {
            this.desarrollador = desarrollador;
            this.textBoxNombre.Text = desarrollador.Nombre.ToString();
            this.textBoxEdad.Text = desarrollador.Edad.ToString();
            this.textBoxExperiencia.Text = desarrollador.Experiencia.ToString();
            this.textBoxSalario.Text = desarrollador.Salario.ToString();
            this.textBoxLenguajeDeProgramacion.Text = desarrollador.LenguajeDeProgramacion.ToString();
            this.textBoxProyectosFinalizados.Text = desarrollador.ProyectosFinalizados.ToString();
            banderaModificar = true;
        }

        /// <summary>
        /// Maneja el evento Click del botón de cancelar, estableciendo el resultado del diálogo como Cancelar.
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Maneja el evento Click del botón de aceptar, valida los datos del desarrollador y los agrega a la lista de empleados de la empresa si son válidos.
        /// </summary>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            bool esValido = true;
            esValido &= Validar(desarrollador, "nombre", textBoxNombre);
            esValido &= Validar(desarrollador, "edad", textBoxEdad);
            esValido &= Validar(desarrollador, "experiencia", textBoxExperiencia);
            esValido &= Validar(desarrollador, "salario", textBoxSalario);
            esValido &= Validar(desarrollador, "lenguaje de programacion", textBoxLenguajeDeProgramacion);
            esValido &= Validar(desarrollador, "proyectos finalizados", textBoxProyectosFinalizados);

            if (esValido)
            {
                if (FormularioPrincipal.abrirBD)
                {
                    if (banderaModificar == false)
                    {
                        Datos.AgregarEmpleado(textBoxNombre.Text, int.Parse(textBoxEdad.Text), int.Parse(textBoxExperiencia.Text), int.Parse(textBoxSalario.Text), textBoxLenguajeDeProgramacion.Text, int.Parse(textBoxProyectosFinalizados.Text),TipoDeEmpleados.Desarrollador);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Datos.ModificarEmpleado(textBoxNombre.Text, int.Parse(textBoxEdad.Text), int.Parse(textBoxExperiencia.Text), int.Parse(textBoxSalario.Text), textBoxLenguajeDeProgramacion.Text, int.Parse(textBoxProyectosFinalizados.Text), TipoDeEmpleados.Desarrollador, desarrollador.Id);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.empresa != desarrollador)
                    {
                        desarrollador.Tipo = TipoDeEmpleados.Desarrollador;
                        this.empresa += desarrollador;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        /// <summary>
        /// Valida los datos de un desarrollador según el tipo de dato especificado y el contenido del cuadro de texto proporcionado.
        /// </summary>
        /// <param name="desarrollador">El objeto desarrollador cuyos datos se están validando.</param>
        /// <param name="dato">El tipo de dato que se está validando (nombre, edad, experiencia, salario, lenguaje de programación, proyectos finalizados).</param>
        /// <param name="textBox">El cuadro de texto que contiene el valor a validar.</param>
        /// <returns>True si el valor es válido y se asigna correctamente al desarrollador; de lo contrario, false.</returns>
        private bool Validar(Desarrollador desarrollador, string dato, TextBox textBox)
        {
            switch (dato)
            {
                case "nombre":
                    return ValidarNombre(desarrollador, textBox);
                case "lenguaje de programacion":
                    return ValidarLenguajeDeProgramacion(desarrollador, textBox);
                case "edad":
                    return ValidarEdad(desarrollador, textBox);
                case "salario":
                    return ValidarSalario(desarrollador, textBox);
                case "experiencia":
                    return ValidarExperiencia(desarrollador, textBox);
                case "proyectos finalizados":
                    return ValidarProyectosFinalizados(desarrollador, textBox);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Valida el valor ingresado en el TextBox para el lenguaje de programación del Desarrollador.
        /// Si el valor no es numérico, lo asigna al Desarrollador y retorna verdadero; de lo contrario, muestra un mensaje de error y retorna falso.
        /// Si el TextBox está vacío, muestra un mensaje de error y retorna falso.
        /// </summary>
        /// <param name="desarrollador">El objeto Desarrollador al que se asignará el lenguaje de programación.</param>
        /// <param name="textBox">El TextBox que contiene el valor del lenguaje de programación.</param>
        /// <returns>Verdadero si la validación es exitosa y se asigna el lenguaje de programación al Desarrollador; de lo contrario, falso.</returns>
        private bool ValidarLenguajeDeProgramacion(Desarrollador desarrollador, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (!int.TryParse(textBox.Text, out _))
                {
                    desarrollador.LenguajeDeProgramacion = textBox.Text;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, el lenguaje de programación no puede estar vacío o ser un número.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para el Lenguaje De Programación");
                return false;
            }
        }

        /// <summary>
        /// Valida el valor ingresado en el TextBox para los proyectos finalizados del Desarrollador.
        /// Si el valor es un número válido, lo asigna al Desarrollador y retorna verdadero; de lo contrario, muestra un mensaje de error y retorna falso.
        /// Si el TextBox está vacío, muestra un mensaje de error y retorna falso.
        /// </summary>
        /// <param name="desarrollador">El objeto Desarrollador al que se asignará la cantidad de proyectos finalizados.</param>
        /// <param name="textBox">El TextBox que contiene el valor de los proyectos finalizados.</param>
        /// <returns>Verdadero si la validación es exitosa y se asigna la cantidad de proyectos finalizados al Desarrollador; de lo contrario, falso.</returns>
        private bool ValidarProyectosFinalizados(Desarrollador desarrollador, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (int.TryParse(textBox.Text, out int proyectosFinalizados))
                {
                    desarrollador.ProyectosFinalizados = proyectosFinalizados;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para los Proyectos Finalizados.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para los Proyectos Finalizados");
                return false;
            }
        }
    }
}


