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
        public Tester tester;
        public Empresa empresa;
        public FormTester()
        {
            InitializeComponent();
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.tester = new Tester("", 0, 0);
            this.empresa = new Empresa();

            this.tester.Nombre = this.textBoxNombre.Text;
            this.tester.Experiencia = int.Parse(this.textBoxExperiencia.Text);
            this.tester.Salario = int.Parse(this.textBoxSalario.Text);
            this.tester.HerramientaDePrueba = this.textBoxHerramientaDePrueba.Text;
            this.tester.ProyectosTesteados = int.Parse(this.textBoxProyectosGestionados.Text);

            if (int.TryParse(this.textBoxEdad.Text, out _))
            {
                if (int.Parse(this.textBoxEdad.Text) > 0 && int.Parse(this.textBoxEdad.Text) < 90)
                {
                    this.tester.Edad = int.Parse(this.textBoxEdad.Text);
                    this.empresa.listaDeEmpleados.Add(this.tester);
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
    }
}
