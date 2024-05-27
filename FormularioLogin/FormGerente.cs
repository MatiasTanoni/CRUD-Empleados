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
        // atributos
        private Gerente gerente = new Gerente("", 0, 0);
        public Empresa empresa;

        // Propiedades
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
        public FormGerente(Empresa empresa) :this()
        {
            this.empresa = empresa;
        }
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
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
                            gerente.Experiencia = experiencia;
                            return true;
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
