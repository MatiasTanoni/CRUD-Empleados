using Entidades;
using Formularios;
namespace Formularios
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioDatos formularioAgregar;
        public Empresa empresa = new Empresa();
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        private void ActualizarVisor()
        {
            if (empresa != null && empresa.listaDeEmpleados != null)
            {
                try
                {
                    foreach (Empleado empleado in this.empresa.listaDeEmpleados)
                    {
                        listBoxPrincipal.Items.Add(empleado.MostrarInformacion());
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

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            this.formularioAgregar = new FormularioDatos(empresa);
            formularioAgregar.ShowDialog();

            if (formularioAgregar.formDesarrollador != null)
            {
                this.listBoxPrincipal.Items.Clear();
                this.ActualizarVisor();
            }
            if (formularioAgregar.formTester != null)
            {
                this.listBoxPrincipal.Items.Clear();

                this.ActualizarVisor();
            }
            if (formularioAgregar.formGerente != null)
            {
                this.listBoxPrincipal.Items.Clear();

                this.ActualizarVisor();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormularioDatos formularioAgregar = new FormularioDatos();
            formularioAgregar.ShowDialog();
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            int indice = this.listBoxPrincipal.SelectedIndex;
            if (indice != -1)
            {
                this.empresa.listaDeEmpleados.RemoveAt(indice);

                this.listBoxPrincipal.Items.Clear();
                this.ActualizarVisor();
            }
        }
    }
}
