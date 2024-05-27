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
    public partial class FormTester : Form
    {
        private Tester tester = new Tester("",0,0);
        public Empresa empresa = new Empresa();

        public Tester Tester 
        { 
            get { return tester; } 
            set { tester = value; }
        }

        public FormTester()
        {
            InitializeComponent();
        }
        public FormTester(Empresa empresa) :this()
        {
            this.empresa = empresa;
        }

        public FormTester(Tester tester) : this()
        {
            this.tester = tester;
            this.textBoxNombre.Text = tester.Nombre.ToString();
            this.textBoxEdad.Text = tester.Edad.ToString();
            this.textBoxExperiencia.Text = tester.Experiencia.ToString();
            this.textBoxSalario.Text = tester.Salario.ToString();
            this.textBoxHerramientaDePrueba.Text = tester.HerramientaDePrueba.ToString();
            this.textBoxProyectosTesteados.Text = tester.ProyectosTesteados.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

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
                this.empresa.ListaDeEmpleados.Add(tester);
                this.DialogResult = DialogResult.OK;
            }
        }
        private bool Validar(Tester tester, string dato, TextBox textBox)
        {
            switch (dato)
            {
                case "nombre":
                    if (!string.IsNullOrWhiteSpace(textBox.Text) && !int.TryParse(textBox.Text, out _))
                    {
                        tester.Nombre = textBox.Text;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, el nombre no puede estar vacío o ser un número.");
                        return false;
                    }
                case "herramienta de prueba":
                    {
                        if (!string.IsNullOrWhiteSpace(textBox.Text) && !int.TryParse(textBox.Text, out _))
                        {
                            tester.HerramientaDePrueba = textBox.Text;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, La HerramientaDePrueba no puede estar vacío o ser un número.");
                            return false;
                        }
                    }
                case "edad":
                    {
                        if (int.TryParse(textBox.Text, out int edad))
                        {
                            if (edad > 0 && edad < 90)
                            {
                                tester.Edad = edad;
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
                            tester.Salario = salario;
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
                            tester.Experiencia = experiencia;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un valor numérico válido para la experiencia.");
                            return false;
                        }
                    }
                case "proyectos testeados":
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
                default:
                    return false;
            }
        }
    }
}

