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

namespace Formularios
{
    public partial class FormDesarrollador : FormBase
    {
        //Atributos
        /// <summary>
        /// Representa un objeto Desarrollador.
        /// Representa una empresa que contiene una lista de empleados.
        /// </summary>
        private Desarrollador desarrollador = new Desarrollador("",0,0);
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

        // Contructor
        public FormDesarrollador()
        {
            InitializeComponent();
            empresa = new Empresa(); // Inicializa la empresa aquí
            empresa.ListaDeEmpleados = new List<Empleado>(); // Inicializa la lista de empleados aquí
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FormDesarrollador"/> con la empresa especificada.
        /// </summary>
        /// <param name="empresa">La empresa asociada al formulario.</param>
        public FormDesarrollador(Empresa empresa) : this()
        {
            this.empresa = empresa;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FormDesarrollador"/> con el desarrollador especificado.
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
        }

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
                if (this.empresa != Desarrollador)
                {
                    this.empresa += desarrollador;
                    this.DialogResult = DialogResult.OK;
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
        private bool Validar(Desarrollador desarrollador, string dato,TextBox textBox)
        {
            switch (dato)
            {
                case "nombre":
                    if (!string.IsNullOrWhiteSpace(textBox.Text) && !int.TryParse(textBox.Text, out _))
                    {
                        desarrollador.Nombre = textBox.Text;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, el nombre no puede estar vacío o ser un número.");
                        return false;
                    }
                case "lenguaje de programacion":
                    {
                        if (!string.IsNullOrWhiteSpace(textBox.Text) && !int.TryParse(textBox.Text, out _))
                        {
                            desarrollador.LenguajeDeProgramacion = textBox.Text;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, El lenguaje de programación no puede estar vacío o ser un número.");
                            return false;
                        }
                    }
                case "edad":
                {
                    if (int.TryParse(textBox.Text, out int edad))
                    {
                        if (edad > 0 && edad < 65)
                        {
                            desarrollador.Edad = edad;
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
                case "salario":
                {
                    if (int.TryParse(textBox.Text, out int salario))
                    {
                        if (salario > 0)
                        {
                            desarrollador.Salario = salario;
                            return true;

                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico mayor a 0 para el salario.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor numérico válido para el salario.");
                        return false;
                    } 
                }

                case "experiencia":
                    {
                        if (int.TryParse(textBox.Text, out int experiencia) )
                        {
                            if(experiencia >= 0 && experiencia <= 40)
                            {
                                desarrollador.Experiencia = experiencia;
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
                case "proyectos finalizados":
                    {
                        if (int.TryParse(textBox.Text, out int proyectosFinalizados))
                        {
                            desarrollador.ProyectosFinalizados = proyectosFinalizados;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para los proyectos finalizados.");
                            return false;
                        }
                    }
                default:
                    return false;
            }
        }
    }
   
}
