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
    public partial class FormularioDatos: FormConfiguraciones
    {
        /// <summary>
        /// Formulario para manejar las acciones relacionadas con un desarrollador.
        /// Formulario para manejar las acciones relacionadas con un tester.
        /// Formulario para manejar las acciones relacionadas con un gerente.
        /// Instancia de la empresa que contiene la lista de empleados.
        /// </summary>
        public FormDesarrollador? formDesarrollador = null;
        public FormTester? formTester = null;
        public FormGerente? formGerente = null;
        public Empresa empresa = new Empresa();

        public FormularioDatos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FormularioDatos"/> con una instancia de <see cref="Empresa"/>.
        /// </summary>
        /// <param name="empresa">La instancia de <see cref="Empresa"/> que contiene la lista de empleados.</param>
        public FormularioDatos(Empresa empresa) : this()
        {
            this.empresa = empresa;
        }

        /// <summary>
        /// Maneja el evento Click del botón Cancelar.
        /// Establece el resultado del diálogo como Cancelar.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Maneja el evento CheckedChanged del RadioButton para seleccionar la opción Desarrollador.
        /// Abre el formulario correspondiente si ninguna otra opción está seleccionada.
        /// Oculta el formulario actual después de realizar la acción.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void radioButtonDesarrollador_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonTester.Checked && !radioButtonGerente.Checked)
            {
                this.formDesarrollador = new FormDesarrollador(this.empresa);
                formDesarrollador.ShowDialog();
            }
            if (this.formDesarrollador != null)
            {
            if (this.formDesarrollador.DialogResult == DialogResult.OK)
            {
                this.formDesarrollador.Close();
            }
                
            }
            this.Hide();
        }

        /// <summary>
        /// Maneja el evento CheckedChanged del RadioButton para seleccionar la opción Tester.
        /// Abre el formulario correspondiente si ninguna otra opción está seleccionada.
        /// Oculta el formulario actual después de realizar la acción.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void radioButtonTester_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDesarrollador.Checked && !radioButtonGerente.Checked)
            {
                this.formTester = new FormTester(this.empresa);
                formTester.ShowDialog();
            }
            this.Hide();
        }

        /// <summary>
        /// Maneja el evento CheckedChanged del RadioButton para seleccionar la opción Gerente.
        /// Abre el formulario correspondiente si ninguna otra opción está seleccionada.
        /// Oculta el formulario actual después de realizar la acción.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void radioButtonGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDesarrollador.Checked && !radioButtonTester.Checked)
            {
                this.formGerente = new FormGerente(this.empresa);
                formGerente.ShowDialog();
            }
            this.Hide();
        }


    }
}
