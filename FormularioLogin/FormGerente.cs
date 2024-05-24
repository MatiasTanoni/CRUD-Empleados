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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.empresa = new Empresa();
            this.gerente = new Gerente("",0,0);
            this.gerente.Nombre = this.textBoxNombre.Text;
            this.gerente.Experiencia = int.Parse(this.textBoxExperiencia.Text);
            this.gerente.Salario = int.Parse(this.textBoxSalario.Text);
            this.gerente.PersonasACargo = int.Parse(this.textBoxPersonasACargo.Text);
            this.gerente.ProyectosGestionados = int.Parse(this.textBoxProyectosGestionados.Text);

            if (int.TryParse(this.textBoxEdad.Text, out _))
            {
                if (int.Parse(this.textBoxEdad.Text) > 0 && int.Parse(this.textBoxEdad.Text) < 90)
                {
                    this.gerente.Edad = int.Parse(this.textBoxEdad.Text);
                    this.empresa.listaDeEmpleados.Add(this.gerente);
                    this.DialogResult = DialogResult.OK;
                    //this.FormularioDatos.Hide();
                }
                else
                {
                    MessageBox.Show("edad inexistente");
                }
            }
            else
            {
                MessageBox.Show("mal ingresado, no has ingresado un numero");
            }
        }

        private void textBoxProyectosGestionados_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
