using Entidades;
using Formularios;
namespace Formularios
{
    public partial class FormularioPrincipal : Form
    {
        public FormDesarrollador formularioDesarrollador = new FormDesarrollador();
        public FormTester formTester = new FormTester();
        public FormGerente formGerente = new FormGerente();
        public FormularioDatos formularioAgregar;
        public Empresa empresa = new Empresa();
        public FormularioPrincipal()
        {
            InitializeComponent();
        }
        private void ActualizarVisor()
        {

            if (empresa != null && empresa.ListaDeEmpleados != null)
            {
                this.listBoxPrincipal.Items.Clear();
                try
                {
                    foreach (Empleado empleado in this.empresa.ListaDeEmpleados)
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
                this.ActualizarVisor();
            }
            if (formularioAgregar.formTester != null)
            {
                this.ActualizarVisor();
            }
            if (formularioAgregar.formGerente != null)
            {
                this.ActualizarVisor();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

            int indice = this.listBoxPrincipal.SelectedIndex;
            if (indice != -1)
            {
                //this.listBoxPrincipal.Items.RemoveAt(indice);

                if (this.empresa.ListaDeEmpleados[indice].GetType() == typeof(Gerente))
                {
                    this.formGerente = new FormGerente((Gerente)this.empresa.ListaDeEmpleados[indice]);
                    this.formGerente.ShowDialog();
                    DialogResult resultado = formGerente.DialogResult;
                    if (resultado == DialogResult.OK)
                    {
                        this.empresa.ListaDeEmpleados[indice] = formGerente.Gerente;
                        this.ActualizarVisor();
                    }
                }
                if (this.empresa.ListaDeEmpleados[indice].GetType() == typeof(Tester))
                {
                    this.formTester = new FormTester((Tester)this.empresa.ListaDeEmpleados[indice]);
                    this.formTester.ShowDialog();
                    DialogResult resultado = formTester.DialogResult;
                    if (resultado == DialogResult.OK)
                    {
                        this.empresa.ListaDeEmpleados[indice] = formTester.Tester;
                        this.ActualizarVisor();
                    }
                }
                if (this.empresa.ListaDeEmpleados[indice].GetType() == typeof(Desarrollador))
                {
                    this.formularioDesarrollador = new FormDesarrollador((Desarrollador)this.empresa.ListaDeEmpleados[indice]);
                    this.formularioDesarrollador.ShowDialog();
                    DialogResult resultado = formularioDesarrollador.DialogResult;
                    if (resultado == DialogResult.OK)
                    {
                        this.empresa.ListaDeEmpleados[indice] = formularioDesarrollador.Desarrollador;
                        this.ActualizarVisor();
                    }
                }
            }
        }


        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            int indice = this.listBoxPrincipal.SelectedIndex;
            if (indice != -1)
            {
                this.empresa.ListaDeEmpleados.RemoveAt(indice);

                this.listBoxPrincipal.Items.Clear();
                this.ActualizarVisor();
            }
        }
    }
}
