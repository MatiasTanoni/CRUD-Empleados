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
using Formularios;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using ADO;

namespace Formularios
{
    /// <summary>
    /// Clase parcial que representa el formulario para manejar información de desarrolladores.
    /// </summary>
    public partial class FormDesarrollador : FormConfiguraciones
    {
        // Atributos
        /// <summary>
        /// Representa un objeto Desarrollador.
        /// </summary>
        private bool banderaModificar = false;
        private Desarrollador desarrollador = new Desarrollador();

        /// <summary>
        /// Representa una empresa que contiene una lista de empleados.
        /// </summary>
        public Empresa empresa = new Empresa();

        // Propiedades
        /// <summary>
        /// Obtiene o establece el objeto Desarrollador asociado.
        /// </summary>
        public Desarrollador Desarrollador
        {
            get { return desarrollador; }
            set { desarrollador = value; }
        }

        // Constructor
        public FormDesarrollador()
        {
            InitializeComponent();
            empresa = new Empresa(); // Inicializa la empresa aquí
            empresa.ListaDeEmpleados = new List<Empleado>(); // Inicializa la lista de empleados aquí
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

        // Eventos
        /// <summary>
        /// Maneja el evento Click del botón de cancelar, estableciendo el resultado del diálogo como Cancelar.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Maneja el evento Click del botón de aceptar, valida los datos del desarrollador y los agrega a la lista de empleados de la empresa si son válidos.
        /// </summary>
        /// <param name="sender">El objeto que generó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
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
                        this.empresa += desarrollador;
                        this.DialogResult = DialogResult.OK;
                    }
                }

            }
        }

        // Métodos de validación
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


