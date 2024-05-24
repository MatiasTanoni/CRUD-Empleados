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
    public partial class FormularioDatos : Form
    {
        //public FormularioDatos formularioDatos;
        public FormDesarrollador formDesarrollador;
        public FormTester formTester;
        public FormGerente formGerente;
        public string tipoDeEmpleado;
        public FormularioDatos()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void radioButtonDesarrollador_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonTester.Checked && !radioButtonGerente.Checked)
            {
                this.formDesarrollador = new FormDesarrollador();
                formDesarrollador.ShowDialog();
            }
            if (this.formDesarrollador.DialogResult == DialogResult.OK)
            {
                this.formDesarrollador.Close();
            }
        }

        private void radioButtonTester_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDesarrollador.Checked && !radioButtonGerente.Checked)
            {
                this.formTester = new FormTester();
                formTester.ShowDialog();                  
            }

        }

        private void radioButtonGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDesarrollador.Checked && !radioButtonTester.Checked)
            {
                this.formGerente = new FormGerente();
                formGerente.ShowDialog();                      
            }

        }
    }
}
