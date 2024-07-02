using ADO;
using Entidades;

namespace Formularios
{
    public partial class FormGerente : FormConfiguraciones
    {
        private Gerente gerente = new Gerente();
        public Empresa empresa;
        private bool banderaModificar = false;

        /// <summary>
        /// Obtiene o establece el objeto Gerente asociado.
        /// </summary>
        /// <value>El objeto Gerente asociado.</value>
        public Gerente Gerente 
        { 
            get { return gerente; } 
            set { gerente = value; }
        }  

        public FormGerente()
        {
            InitializeComponent();
            empresa = new Empresa();
            empresa.ListaDeEmpleados = new List<Empleado>();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormGerente con empresa asociada.
        /// </summary>
        /// <param name="empresa">La empresa asociada al formulario.</param>
        public FormGerente(Empresa empresa) :this()
        {
            this.empresa = empresa;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Cancelar".
        /// Establece el resultado del diálogo como Cancelar.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase FormGerente con un objeto Gerente especificado.
        /// </summary>
        /// <param name="gerente">El objeto Gerente con el que se inicializa el formulario.</param>
        public FormGerente(Gerente gerente) : this()
        {
            this.gerente = gerente;
            this.textBoxNombre.Text = gerente.Nombre.ToString();
            this.textBoxEdad.Text = gerente.Edad.ToString();
            this.textBoxExperiencia.Text = gerente.Experiencia.ToString();
            this.textBoxSalario.Text = gerente.Salario.ToString();
            this.textBoxPersonasACargo.Text = gerente.PersonasACargo.ToString();
            this.textBoxProyectosGestionados.Text = gerente.ProyectosGestionados.ToString();
            banderaModificar = true;
        }

        /// <summary>
        /// Maneja el evento de clic en el botón "Aceptar" del formulario.
        /// Valida los datos del gerente y, si son válidos, los agrega a la lista de empleados de la empresa.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            bool esValido = true;
            esValido &= Validar(gerente, "nombre", textBoxNombre);
            esValido &= Validar(gerente, "edad", textBoxEdad);
            esValido &= Validar(gerente, "experiencia", textBoxExperiencia);
            esValido &= Validar(gerente, "salario", textBoxSalario);
            esValido &= Validar(gerente, "personas a cargo", textBoxPersonasACargo);
            esValido &= Validar(gerente, "proyectos gestionados", textBoxProyectosGestionados);

            if (esValido)
            {
                if (FormularioPrincipal.abrirBD)
                {
                    if (banderaModificar == false)
                    {
                        Datos.AgregarEmpleado(textBoxNombre.Text,int.Parse(textBoxEdad.Text),int.Parse(textBoxExperiencia.Text),int.Parse(textBoxSalario.Text),int.Parse(textBoxPersonasACargo.Text),TipoDeEmpleados.Gerente,int.Parse(textBoxProyectosGestionados.Text));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Datos.ModificarEmpleado(textBoxNombre.Text,int.Parse(textBoxEdad.Text),int.Parse(textBoxExperiencia.Text),int.Parse(textBoxSalario.Text),int.Parse(textBoxPersonasACargo.Text),int.Parse(textBoxProyectosGestionados.Text),Gerente.Id,TipoDeEmpleados.Gerente);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (this.empresa != gerente)
                    {
                        gerente.Tipo = TipoDeEmpleados.Gerente;
                        this.empresa += gerente;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        /// <summary>
        /// Valida los datos de un gerente.
        /// </summary>
        /// <param name="gerente">El objeto Gerente cuyos datos se van a validar.</param>
        /// <param name="dato">El tipo de dato que se está validando (nombre, proyectos gestionados, edad, salario, experiencia o personas a cargo).</param>
        /// <param name="textBox">El cuadro de texto que contiene el valor a validar.</param>
        /// <returns>
        /// Devuelve true si el dato es válido y se ha actualizado correctamente en el objeto Gerente, de lo contrario, devuelve false.
        /// </returns>
        private bool Validar(Gerente gerente, string dato, TextBox textBox)
        {
            switch (dato)
            {
                case "nombre":
                    return ValidarNombre(gerente,textBox);
                case "proyectos gestionados":
                    return ValidarProyectosGestionados(gerente,textBox);
                case "edad":
                    return ValidarEdad(gerente,textBox);
                case "salario":
                    return ValidarSalario(gerente,textBox);
                case "experiencia":
                    return ValidarExperiencia(gerente,textBox);
                case "personas a cargo":
                    return ValidarPersonasACargo(gerente,textBox);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Valida el valor ingresado en el TextBox para los proyectos gestionados por el Gerente.
        /// Si el valor es numérico, lo asigna al Gerente y retorna verdadero; de lo contrario, muestra un mensaje de error y retorna falso.
        /// Si el TextBox está vacío, muestra un mensaje de error y retorna falso.
        /// </summary>
        /// <param name="gerente">El objeto Gerente al que se asignarán los proyectos gestionados.</param>
        /// <param name="textBox">El TextBox que contiene el valor de los proyectos gestionados.</param>
        /// <returns>Verdadero si la validación es exitosa y se asignan los proyectos gestionados al Gerente; de lo contrario, falso.</returns>
        private bool ValidarProyectosGestionados(Gerente gerente, TextBox textBox) 
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (int.TryParse(textBox.Text, out int ProyectosGestionados))
                {
                    gerente.ProyectosGestionados = ProyectosGestionados;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para el valor de Proyectos Gestionados.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para los Proyectos Gestionados.");
                return false;
            }
        }

        /// <summary>
        /// Valida el valor ingresado en el TextBox para las personas a cargo del Gerente.
        /// Si el valor es numérico, lo asigna al Gerente y retorna verdadero; de lo contrario, muestra un mensaje de error y retorna falso.
        /// Si el TextBox está vacío, muestra un mensaje de error y retorna falso.
        /// </summary>
        /// <param name="gerente">El objeto Gerente al que se asignarán las personas a cargo.</param>
        /// <param name="textBox">El TextBox que contiene el valor de las personas a cargo.</param>
        /// <returns>Verdadero si la validación es exitosa y se asignan las personas a cargo al Gerente; de lo contrario, falso.</returns>
        private bool ValidarPersonasACargo(Gerente gerente, TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {

                if (int.TryParse(textBox.Text, out int PersonasACargo))
                {
                    gerente.PersonasACargo = PersonasACargo;
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para el valor de Personas a cargo.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, No puede estar vacio, ingrese un valor para las Personas A Cargo.");
                return false;
            }
        }
    }
}