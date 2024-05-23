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
            this.actualizarVisor(this.formularioAgregar.formDesarrollador.empresa);
        }
        private void actualizarVisor(Empresa empresa)
        {
            foreach (Empleado empleado in empresa.listaDeEmpleados)
            {
                this.listBoxPrincipal.Items.Add(empleado.MostrarInformacion());
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
