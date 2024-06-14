using Entidades;
using Formularios;
using System.Collections.Immutable;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
namespace Formularios
{
    public partial class FormularioPrincipal : Form
    {
        /// <summary>
        /// Formulario para manejar datos de desarrolladores.
        /// Formulario para manejar datos de testers.
        /// Formulario para manejar datos de gerentes.
        /// Formulario para agregar nuevos empleados.
        /// Empresa que contiene la lista de empleados.
        /// El usuario registrado.
        /// </summary>
        public FormDesarrollador formularioDesarrollador = new FormDesarrollador();
        public FormTester formTester = new FormTester();
        public FormGerente formGerente = new FormGerente();
        public FormularioDatos formularioAgregar;
        public Empresa empresa = new Empresa();
        public Usuario usuarioRegistrado;

        /// <summary>
        /// Obtiene o establece la ruta actual.
        /// </summary>
        public string PathCurrent { get; set; }

        /// <summary>
        /// Constructor por defecto de la clase FormularioPrincipal.
        /// </summary>
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.listBoxPrincipal.HorizontalScrollbar = true;
            this.FormClosing += FormularioPrincipal_FormClosing;
        }
        /// <summary>
        /// Constructor de la clase FormularioPrincipal que recibe un usuario registrado.
        /// </summary>
        /// <param name="usuarioRegistrado">El usuario registrado que utilizará el formulario principal.</param>
        public FormularioPrincipal(Usuario usuarioRegistrado) : this()
        {
            this.usuarioRegistrado = usuarioRegistrado;
        }

        /// <summary>
        /// Actualiza la lista de empleados en el ListBox de la interfaz de usuario.
        /// </summary>
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


        /// <summary>
        /// Maneja el evento de clic del botón "Agregar" para abrir el formulario de datos y agregar un nuevo empleado.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            buttonModificar.Enabled = true;
            buttonEliminar.Enabled = true;
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
        /// <summary>
        /// Maneja el evento de clic del botón "Modificar" para abrir el formulario correspondiente y modificar el empleado seleccionado.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
            int indice = this.listBoxPrincipal.SelectedIndex;
            if (indice != -1)
            {
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
                else if (this.empresa.ListaDeEmpleados[indice].GetType() == typeof(Tester))
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
                else if (this.empresa.ListaDeEmpleados[indice].GetType() == typeof(Desarrollador))
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

        /// <summary>
        /// Maneja el evento de clic del botón "Eliminar" para eliminar el empleado seleccionado de la lista.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres Eliminar este empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int indice = this.listBoxPrincipal.SelectedIndex;
                if (indice != -1)
                {
                    this.empresa -= this.empresa.ListaDeEmpleados[indice];
                    this.listBoxPrincipal.Items.Clear();
                    this.ActualizarVisor();
                }
            }

        }

        /// <summary>
        /// Maneja el evento Load del formulario principal.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelOperador.Text = $"Operador: {this.usuarioRegistrado.Nombre}";
            toolStripStatusLabelFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Maneja el evento Click del botón de guardar.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PathCurrent))
            {
                GuardarComo();
            }
            else
            {
                GuardarArchivo(PathCurrent);
            }

        }


        ///  /// <summary>
        /// Abre un cuadro de diálogo de guardar como y guarda el contenido del listBox en un archivo JSON.
        /// </summary>
        private void GuardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo JSON |*.json";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;

                var items = new List<string>();
                foreach (var item in listBoxPrincipal.Items)
                {
                    items.Add(item.ToString());
                }

                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                string jsonContent = JsonSerializer.Serialize(items, jsonOptions);

                File.WriteAllText(path, jsonContent);
            }
        }

        /// <summary>
        /// Guarda el contenido del listBox en un archivo en la ruta especificada.
        /// </summary>
        /// <param name="pathCurrent">La ruta del archivo en la que se guardará el contenido.</param>
        private void GuardarArchivo(string pathCurrent)
        {
            try
            {
                // Obtenemos el contenido del listBox
                string content = listBoxPrincipal.Text;

                // Guardamos el contenido en el archivo
                File.WriteAllText(pathCurrent, content);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Maneja el evento Click del botón de abrir archivo.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                try
                {
                    string jsonContent = File.ReadAllText(path);

                    var items = JsonSerializer.Deserialize<List<string>>(jsonContent);

                    listBoxPrincipal.Items.Clear();

                    foreach (var item in items)
                    {
                        listBoxPrincipal.Items.Add(item);
                    }
                    buttonModificar.Enabled = false;
                    buttonEliminar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Maneja el evento de cierre del formulario principal.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonAscendente_Click(object sender, EventArgs e)
        {
            var empleadosOrdenados = empresa.ListaDeEmpleados.OrderBy(e => e.Nombre).ToList();
            listBoxPrincipal.Items.Clear();
            foreach (var item in empleadosOrdenados)
            {
                listBoxPrincipal.Items.Add(item.MostrarInformacion());
            }
        }

        private void buttonDescendente_Click(object sender, EventArgs e)
        {
            var empleadosOrdenados = empresa.ListaDeEmpleados.OrderByDescending(e => e.Nombre).ToList();
            listBoxPrincipal.Items.Clear();
            foreach (var item in empleadosOrdenados)
            {
                listBoxPrincipal.Items.Add(item.MostrarInformacion());
            }
        }

        private void buttonVisualizador_Click_1(object sender, EventArgs e)
        {
            FormVisualizador formVisualizador = new FormVisualizador();
            formVisualizador.ShowDialog();
        }

    }
}


