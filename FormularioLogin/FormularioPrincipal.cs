using ADO;
using Entidades;
using Formularios;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;
using Timer = System.Windows.Forms.Timer;
namespace Formularios
{
    public partial class FormularioPrincipal : FormConfiguraciones
    {
        /// <summary>
        /// Formulario para manejar datos de desarrolladores.
        /// Formulario para manejar datos de testers.
        /// Formulario para manejar datos de gerentes.
        /// Formulario para agregar nuevos empleados.
        /// Empresa que contiene la lista de empleados.
        /// El usuario registrado.
        /// </summary>
        public FormDesarrollador? formularioDesarrollador = new FormDesarrollador();
        public FormTester? formTester = new FormTester();
        public FormGerente? formGerente = new FormGerente();
        public FormularioDatos? formularioAgregar;
        public Empresa empresa = new Empresa();
        public Usuario? usuarioRegistrado;
        public static bool abrirBD = false;
        private Tiempo tiempo;
        private Timer timer;

        /// <summary>
        /// Obtiene o establece la ruta actual.
        /// </summary>
        public string PathCurrent { get; set; } = string.Empty;


        /// <summary>
        /// Constructor por defecto de la clase FormularioPrincipal.
        /// </summary>
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.listBoxPrincipal.HorizontalScrollbar = true;
            FormClosing += FormularioPrincipal_FormClosing;
            panelArchivos.BackColor = Color.Red;

            tiempo = new Tiempo();
            tiempo.SegundoCambiado += MostrarCambioTiempo;
            timer = new Timer();
            timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Constructor de la clase FormularioPrincipal que recibe un usuario registrado.
        /// </summary>
        /// <param name="usuarioRegistrado">El usuario registrado que utilizará el formulario principal.</param>
        public FormularioPrincipal(Usuario usuarioRegistrado) : this()
        {
            try
            {
                this.usuarioRegistrado = usuarioRegistrado;

                if (this.usuarioRegistrado != null)
                {
                    if (this.usuarioRegistrado.Perfil == "supervisor")
                    {
                        buttonEliminar.Enabled = false;
                    }
                    else if (this.usuarioRegistrado.Perfil == "vendedor")
                    {
                        buttonEliminar.Enabled = false;
                        buttonAgregar.Enabled = false;
                        buttonModificar.Enabled = false;
                    }
                }
                else
                {
                    throw new ArgumentNullException(nameof(usuarioRegistrado), "El usuario registrado no puede ser nulo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

        }

        /// <summary>
        /// Actualiza la lista de empleados en el ListBox de la interfaz de usuario.
        /// </summary>
        private void ActualizarVisor()
        {
            if (empresa.ListaDeEmpleados != null)
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
            if (abrirBD)
            {
                empresa.ListaDeEmpleados = Datos.ListarEmpleados();
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
                    Gerente gerente = (Gerente)this.empresa.ListaDeEmpleados[indice];
                    this.formGerente = new FormGerente(gerente);
                    this.formGerente.ShowDialog();
                    DialogResult resultado = formGerente.DialogResult;
                    if (resultado == DialogResult.OK)
                    {
                        gerente = formGerente.Gerente;
                        this.ActualizarVisor();
                    }
                }
                else if (this.empresa.ListaDeEmpleados[indice].GetType() == typeof(Tester))
                {
                    Tester tester = (Tester)this.empresa.ListaDeEmpleados[indice];
                    this.formTester = new FormTester(tester);
                    this.formTester.ShowDialog();
                    DialogResult resultado = formTester.DialogResult;
                    if (resultado == DialogResult.OK)
                    {
                        tester = formTester.Tester;
                        this.ActualizarVisor();
                    }
                }
                else if (this.empresa.ListaDeEmpleados[indice].GetType() == typeof(Desarrollador))
                {
                    Desarrollador desarrollador = (Desarrollador)this.empresa.ListaDeEmpleados[indice];
                    this.formularioDesarrollador = new FormDesarrollador(desarrollador);
                    this.formularioDesarrollador.ShowDialog();
                    DialogResult resultado = formularioDesarrollador.DialogResult;
                    if (resultado == DialogResult.OK)
                    {
                        desarrollador = formularioDesarrollador.Desarrollador;
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
                    // Obtener el empleado seleccionado
                    Empleado empleadoSeleccionado = this.empresa.ListaDeEmpleados[indice];

                    // Verificar que el empleado pertenece a la empresa
                    if (this.empresa.ListaDeEmpleados.Contains(empleadoSeleccionado))
                    {
                        // Eliminar el empleado de la lista de la empresa
                        this.empresa -= empleadoSeleccionado;

                        // Actualizar la interfaz de usuario
                        this.listBoxPrincipal.Items.Clear();
                        this.ActualizarVisor();
  
                        if (abrirBD == true)
                        {
                            Datos.EliminarEmpleado(empleadoSeleccionado.Id);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un empleado de la lista para eliminar.");
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
            if (this.usuarioRegistrado != null)
            {
                toolStripStatusLabelOperador.Text = $"Operador: {this.usuarioRegistrado.Nombre}";
                toolStripStatusLabelFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
                timer.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempo.SimularCambioTiempo();
        }

        public void MostrarCambioTiempo(object reloj, InfoTiempoEventArgs info)
        {
            labelTiempo.Text = $"{info.Hora:D2}:{info.Minuto:D2}:{info.Segundos:D2}";
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

        /// <summary>
        /// Abre un cuadro de diálogo de guardar como y guarda el contenido del listBox en un archivo XML.
        /// </summary>
        private void GuardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo XML |*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;

                var items = new List<string>();
                foreach (var item in listBoxPrincipal.Items)
                {
                    string itemString = item?.ToString() ?? "Valor nulo";
                    items.Add(itemString);
                    //items.Add(item.ToString());
                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Empleado>));
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    xmlSerializer.Serialize(streamWriter, this.empresa.ListaDeEmpleados);

                }
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
                var items = new List<string>();
                foreach (var item in listBoxPrincipal.Items)
                {
                    string itemString = item?.ToString() ?? "Valor nulo";
                    items.Add(itemString);
                    //items.Add(item.ToString());

                }

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Empleado>));

                using (StreamWriter streamWriter = new StreamWriter(pathCurrent))
                {
                    xmlSerializer.Serialize(streamWriter, this.empresa.ListaDeEmpleados);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                try
                {
                    string xmlContent = File.ReadAllText(path);


                    // Deserializar lista de empleados
                    XmlSerializer xmlSerializerEmpleado = new XmlSerializer(typeof(List<Empleado>));
                    List<Empleado> empleados;
                    using (StringReader reader = new StringReader(xmlContent))
                    {
                        //empleados = (List<Empleado>)xmlSerializerEmpleado.Deserialize(reader);
                        var resultado = xmlSerializerEmpleado.Deserialize(reader);

                        if (resultado != null)
                        {
                            empleados = (List<Empleado>)resultado;
                        }
                        else
                        {
                            empleados = new List<Empleado>(); // Asignar una lista vacía o manejar el caso de null adecuadamente
                        }
                    }

                    if (empleados != null)
                    {
                        panelArchivos.BackColor = Color.Red;
                        panelBD.BackColor = Color.Gainsboro;
                        // Asignar la lista de empleados a la propiedad correspondiente
                        this.empresa.ListaDeEmpleados = empleados;

                        // Limpiar y llenar el listBox con los elementos deserializados
                        listBoxPrincipal.Items.Clear();
                        foreach (var empleado in empleados)
                        {

                            listBoxPrincipal.Items.Add(empleado.MostrarInformacion());
                        }

                    }
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
        private void FormularioPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }


        private void buttonAscendente_Click(object sender, EventArgs e)
        {
            var empleadosOrdenados = new List<Empleado>();
            switch (comboBoxPrincipal.Text)
            {
                case "Nombre":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderBy(e => e.Nombre).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                case "Edad":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderBy(e => e.Edad).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                case "Experiencia":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderBy(e => e.Experiencia).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                case "Salario":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderBy(e => e.Salario).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                default:
                    break;
            }

            listBoxPrincipal.Items.Clear();
            foreach (var item in this.empresa.ListaDeEmpleados)
            {
                listBoxPrincipal.Items.Add(item.MostrarInformacion());
            }
        }

        private void buttonDescendente_Click(object sender, EventArgs e)
        {
            var empleadosOrdenados = new List<Empleado>();

            switch (comboBoxPrincipal.Text)
            {
                case "Nombre":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderByDescending(e => e.Nombre).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                case "Edad":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderByDescending(e => e.Edad).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                case "Experiencia":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderByDescending(e => e.Experiencia).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                case "Salario":
                    empleadosOrdenados = empresa.ListaDeEmpleados.OrderByDescending(e => e.Salario).ToList();
                    this.empresa.ListaDeEmpleados = empleadosOrdenados;
                    break;
                default:
                    break;
            }
            listBoxPrincipal.Items.Clear();
            foreach (var item in this.empresa.ListaDeEmpleados)
            {
                listBoxPrincipal.Items.Add(item.MostrarInformacion());
            }
        }

        private void buttonVisualizador_Click_1(object sender, EventArgs e)
        {
            FormVisualizador formVisualizador = new FormVisualizador();
            formVisualizador.ShowDialog();
        }

        private void buttonAbrirBaseDeDatos_Click(object sender, EventArgs e)
        {
            abrirBD = true;
            empresa.ListaDeEmpleados = Datos.ListarEmpleados();
            this.ActualizarVisor();
            panelArchivos.BackColor = Color.Gainsboro;
            panelBD.BackColor = Color.Red;
        }
    }
}


