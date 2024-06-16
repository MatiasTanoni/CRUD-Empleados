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
    public partial class FormConfiguraciones : Form
    {
        public FormConfiguraciones()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            // Configuraciones comunes para todos los formularios
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           
        }
    }
}
