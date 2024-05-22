using Formularios;
namespace FormularioLogin
{
    public partial class FormularioPrincipal : Form
    {
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
            FormularioDatos formularioAgregar = new FormularioDatos();
            formularioAgregar.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            FormularioDatos formularioAgregar = new FormularioDatos();
            formularioAgregar.ShowDialog();
        }
    }
}
