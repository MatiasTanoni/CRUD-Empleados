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
    public partial class FormDesarrollador : Form
    {
        public Empresa empresa;
        public Desarrollador desarrollador;
        public FormDesarrollador()
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

            this.desarrollador = new Desarrollador("", 0, 0);
            this.desarrollador.Nombre = this.textBoxNombre.Text;

            if (int.TryParse(this.textBoxEdad.Text,out _))
            {
                if (int.Parse(this.textBoxEdad.Text) > 0 && int.Parse(this.textBoxEdad.Text) < 99)
                {
                    this.desarrollador.Edad = int.Parse(this.textBoxEdad.Text);
                    this.empresa.listaDeEmpleados.Add(this.desarrollador);
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    MessageBox.Show("edad incorrecta crack");
                }
            }
            else
            {
                MessageBox.Show("CAPO UN NUMERO NO UNA LETRA");
            }

        }

        private void textBoxNombre_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
