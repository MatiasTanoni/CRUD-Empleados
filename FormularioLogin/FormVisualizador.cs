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
    public partial class FormVisualizador : FormConfiguraciones
    {
        /// <summary>
        /// Constructor por defecto de la clase FormVisualizador.
        /// </summary>
        public FormVisualizador()
        {
            InitializeComponent();
            MostrarHistorialVisualizador();
        }

        /// <summary>
        /// Muestra el historial en el visualizador.
        /// </summary>
        private void MostrarHistorialVisualizador()
        {
            // Ruta absoluta del archivo de historial
            string historial = "usuarios.log";

            try
            {
                // Leer el contenido del archivo de historial
                using (StreamReader streamReader = new StreamReader(historial))
                {
                    string datosHistorial = streamReader.ReadToEnd();
                    StringBuilder stringBuilder = new StringBuilder();

                    // Construir el texto del historial línea por línea
                    foreach (var linea in datosHistorial)
                    {
                        stringBuilder.Append(linea);
                    }

                    // Mostrar el historial en el visualizador
                    richTextBoxVisualizador.Text = stringBuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo log: {ex.Message}");
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Volver".
        /// Establece el resultado del diálogo como Cancelar.
        /// </summary>
        /// <param name="sender">El origen del evento.</param>
        /// <param name="e">Los datos del evento.</param>
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
