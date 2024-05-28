using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Formularios
{
    public partial class FormGerente : Form
    {
        /// <summary>
        /// Representa un objeto Gerente con atributos predeterminados.
        /// Representa una empresa asociada a la clase.
        /// </summary>
        private Gerente gerente = new Gerente("", 0, 0);
        public Empresa empresa;

        /// <summary>
        /// Obtiene o establece el objeto Gerente asociado.
        /// </summary>
        /// <value>El objeto Gerente asociado.</value>
        public Gerente Gerente 
        { 
            get { return gerente; } 
            set { gerente = value; }
        }  

        // Constructores
        public FormGerente()
        {
            InitializeComponent();
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
                this.empresa.ListaDeEmpleados.Add(gerente);
                this.DialogResult = DialogResult.OK;
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
                    if (!string.IsNullOrWhiteSpace(textBox.Text) && !int.TryParse(textBox.Text, out _))
                    {
                        gerente.Nombre = textBox.Text;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, el nombre no puede estar vacío o ser un número.");
                        return false;
                    }
                case "proyectos gestionados":
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
                case "edad":
                    {
                        if (int.TryParse(textBox.Text, out int edad))
                        {
                            if (edad > 0 && edad < 90)
                            {
                                gerente.Edad = edad;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Por favor, ingrese una edad válida (entre 1 y 89).");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para la edad.");
                            return false;
                        }
                    }
                case "salario":
                    {
                        if (int.TryParse(textBox.Text, out int salario))
                        {
                            gerente.Salario = salario;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para el salario.");
                            return false;
                        }
                    }
                case "experiencia":
                    {
                        if (int.TryParse(textBox.Text, out int experiencia))
                        {
                            if (experiencia >= 0 && experiencia < 90)
                            {
                                gerente.Experiencia = experiencia;
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Por favor, ingrese una experiencia válida (entre 0 y 89).");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para la experiencia.");
                            return false;
                        }
                    }
                case "personas a cargo":
                    {
                        if (int.TryParse(textBox.Text, out int PersonasACargo))
                        {
                            gerente.PersonasACargo = PersonasACargo;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para las personas a cargo.");
                            return false;
                        }
                    }
                default:
                    return false;
            }
        }

    }
}
