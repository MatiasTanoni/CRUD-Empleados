using Entidades;
using Formularios;
namespace FormularioLogin
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioDatos formularioAgregar;
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormularioDatos formularioAgregar = new FormularioDatos();
            formularioAgregar.ShowDialog();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.formularioAgregar = new FormularioDatos();
            formularioAgregar.ShowDialog();

            if (formularioAgregar.formDesarrollador != null)
            {
                this.actualizarVisor(this.formularioAgregar.formDesarrollador.empresa);
            }
            if (formularioAgregar.formTester != null)
            {
                this.actualizarVisor(this.formularioAgregar.formTester.empresa);
            }
            if(formularioAgregar.formGerente != null)
            {
                this.actualizarVisor(this.formularioAgregar.formGerente.empresa);
            }
        }
        private void actualizarVisor(Empresa empresa)
        {
            if (empresa != null && empresa.listaDeEmpleados != null)
            {
                try
                {
                    foreach (Empleado empleado in empresa.listaDeEmpleados)
                    {
                        this.listBoxPrincipal.Items.Add(empleado.MostrarInformacion());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar datos: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No agregaste nada a la lista de empleados.");
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            FormularioDatos formularioAgregar = new FormularioDatos();
            formularioAgregar.ShowDialog();
        }

        private void listBoxPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
