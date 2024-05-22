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
    public partial class FormularioDatos : Form
    {
        public FormularioDatos()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonDesarrollador_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
