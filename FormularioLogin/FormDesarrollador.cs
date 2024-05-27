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

namespace Formularios
{
    public partial class FormDesarrollador : Form
    {
        //Atributos
        private Desarrollador desarrollador = new Desarrollador("",0,0);
        public Empresa empresa = new Empresa();

        public Desarrollador Desarrollador
        {
            get { return desarrollador; }
            set { desarrollador = value; }
        }

        // Contructor
        public FormDesarrollador()
        {
            InitializeComponent();
        }
        public FormDesarrollador(Empresa empresa) : this()
        {
            this.empresa = empresa;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

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
                this.empresa.listaDeEmpleados.Add(desarrollador);
                this.DialogResult = DialogResult.OK;
            }
        }
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
                    if (edad > 0 && edad < 90)
                    {
                        desarrollador.Edad = edad;
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
                            desarrollador.Salario = salario;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para el salario.");
                            return false ;
                        }
                    }
                case "experiencia":
                    {
                        if (int.TryParse(textBox.Text, out int experiencia))
                        {
                            desarrollador.Experiencia = experiencia;
                            return true;
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
