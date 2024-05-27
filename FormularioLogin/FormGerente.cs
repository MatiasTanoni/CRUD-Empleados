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
    public partial class FormGerente : Form
    {
        public Empresa empresa;
        public Gerente gerente;
        public FormGerente()
        {
            InitializeComponent();
        }
        public FormGerente(Empresa empresa) :this()
        {
            this.empresa = empresa;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.gerente = new Gerente("", 0, 0);

            bool esValido = true;

            if (!string.IsNullOrWhiteSpace(this.textBoxNombre.Text) && !int.TryParse(this.textBoxNombre.Text, out _))
            {
                this.gerente.Nombre = this.textBoxNombre.Text;
            }
            else
            {
                MessageBox.Show("Por favor, el nombre no puede estar vacío o ser un número.");
                esValido = false;
            }

            if (int.TryParse(this.textBoxEdad.Text, out int edad))
            {
                if (edad > 0 && edad < 90)
                {
                    this.gerente.Edad = edad;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una edad válida (entre 1 y 89).");
                    esValido = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la edad.");
                esValido = false;
            }

            if (int.TryParse(this.textBoxExperiencia.Text, out int experiencia))
            {
                this.gerente.Experiencia = experiencia;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la experiencia.");
                esValido = false;
            }

            if (int.TryParse(this.textBoxSalario.Text, out int salario))
            {
                this.gerente.Salario = salario;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el salario.");
                esValido = false;
            }

            if (int.TryParse(this.textBoxPersonasACargo.Text, out int personasACargo))
            {
                this.gerente.PersonasACargo = personasACargo;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para Personas a Cargo.");
                esValido = false;
            }

            if (int.TryParse(this.textBoxProyectosGestionados.Text, out int proyectosGestionados))
            {
                this.gerente.ProyectosGestionados = proyectosGestionados;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para Proyectos Gestionados.");
                esValido = false;
            }

            if (esValido)
            {
                this.empresa.listaDeEmpleados.Add(this.gerente);
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
