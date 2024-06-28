namespace Formularios
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelOperador = new ToolStripStatusLabel();
            toolStripStatusLabelFecha = new ToolStripStatusLabel();
            buttonGuardar = new Button();
            Abrir = new Button();
            buttonAscendente = new Button();
            buttonDescendente = new Button();
            listBoxPrincipal = new ListBox();
            comboBoxPrincipal = new ComboBox();
            buttonVisualizador = new Button();
            panelArchivos = new Panel();
            label1 = new Label();
            panelBD = new Panel();
            labelBaseDeDatos = new Label();
            buttonAbrirBaseDeDatos = new Button();
            labelTiempo = new Label();
            pictureBox1 = new PictureBox();
            panelTiempo = new Panel();
            statusStrip1.SuspendLayout();
            panelArchivos.SuspendLayout();
            panelBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTiempo.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.OliveDrab;
            buttonAgregar.FlatStyle = FlatStyle.Popup;
            buttonAgregar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(194, 389);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(127, 62);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click_1;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.DarkRed;
            buttonEliminar.FlatStyle = FlatStyle.Popup;
            buttonEliminar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(591, 389);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(127, 62);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click_1;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = SystemColors.ActiveCaption;
            buttonModificar.FlatStyle = FlatStyle.Popup;
            buttonModificar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonModificar.Location = new Point(397, 389);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(127, 62);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelOperador, toolStripStatusLabelFecha });
            statusStrip1.Location = new Point(0, 481);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(813, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelOperador
            // 
            toolStripStatusLabelOperador.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabelOperador.Name = "toolStripStatusLabelOperador";
            toolStripStatusLabelOperador.Size = new Size(159, 17);
            toolStripStatusLabelOperador.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelFecha
            // 
            toolStripStatusLabelFecha.Font = new Font("Lucida Sans", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabelFecha.Name = "toolStripStatusLabelFecha";
            toolStripStatusLabelFecha.Size = new Size(159, 17);
            toolStripStatusLabelFecha.Text = "toolStripStatusLabel2";
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.OliveDrab;
            buttonGuardar.FlatStyle = FlatStyle.Popup;
            buttonGuardar.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(105, 54);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(89, 23);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click_1;
            // 
            // Abrir
            // 
            Abrir.BackColor = SystemColors.ActiveCaption;
            Abrir.FlatStyle = FlatStyle.Popup;
            Abrir.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Abrir.ForeColor = Color.White;
            Abrir.Location = new Point(3, 54);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(89, 23);
            Abrir.TabIndex = 7;
            Abrir.Text = "Abrir";
            Abrir.UseVisualStyleBackColor = false;
            Abrir.Click += Abrir_Click;
            // 
            // buttonAscendente
            // 
            buttonAscendente.BackColor = Color.Gainsboro;
            buttonAscendente.FlatStyle = FlatStyle.Popup;
            buttonAscendente.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAscendente.ForeColor = Color.Black;
            buttonAscendente.Location = new Point(141, 6);
            buttonAscendente.Name = "buttonAscendente";
            buttonAscendente.Size = new Size(123, 49);
            buttonAscendente.TabIndex = 9;
            buttonAscendente.Text = "Ascendente";
            buttonAscendente.UseVisualStyleBackColor = false;
            buttonAscendente.Click += buttonAscendente_Click;
            // 
            // buttonDescendente
            // 
            buttonDescendente.BackColor = Color.Gainsboro;
            buttonDescendente.FlatStyle = FlatStyle.Popup;
            buttonDescendente.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDescendente.ForeColor = Color.Black;
            buttonDescendente.Location = new Point(12, 6);
            buttonDescendente.Name = "buttonDescendente";
            buttonDescendente.Size = new Size(123, 49);
            buttonDescendente.TabIndex = 10;
            buttonDescendente.Text = "Descendente";
            buttonDescendente.UseVisualStyleBackColor = false;
            buttonDescendente.Click += buttonDescendente_Click;
            // 
            // listBoxPrincipal
            // 
            listBoxPrincipal.BackColor = Color.Silver;
            listBoxPrincipal.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxPrincipal.FormattingEnabled = true;
            listBoxPrincipal.ItemHeight = 15;
            listBoxPrincipal.Location = new Point(12, 105);
            listBoxPrincipal.Name = "listBoxPrincipal";
            listBoxPrincipal.ScrollAlwaysVisible = true;
            listBoxPrincipal.Size = new Size(789, 274);
            listBoxPrincipal.TabIndex = 11;
            // 
            // comboBoxPrincipal
            // 
            comboBoxPrincipal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrincipal.FormattingEnabled = true;
            comboBoxPrincipal.Items.AddRange(new object[] { "Nombre", "Edad", "Experiencia", "Salario" });
            comboBoxPrincipal.Location = new Point(54, 62);
            comboBoxPrincipal.Name = "comboBoxPrincipal";
            comboBoxPrincipal.Size = new Size(155, 23);
            comboBoxPrincipal.TabIndex = 12;
            // 
            // buttonVisualizador
            // 
            buttonVisualizador.BackColor = Color.FromArgb(64, 64, 64);
            buttonVisualizador.FlatStyle = FlatStyle.Popup;
            buttonVisualizador.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVisualizador.ForeColor = Color.White;
            buttonVisualizador.Location = new Point(270, 6);
            buttonVisualizador.Name = "buttonVisualizador";
            buttonVisualizador.Size = new Size(121, 92);
            buttonVisualizador.TabIndex = 5;
            buttonVisualizador.Text = "Visualizador";
            buttonVisualizador.UseVisualStyleBackColor = false;
            buttonVisualizador.Click += buttonVisualizador_Click_1;
            // 
            // panelArchivos
            // 
            panelArchivos.BackColor = Color.Gainsboro;
            panelArchivos.BorderStyle = BorderStyle.FixedSingle;
            panelArchivos.Controls.Add(label1);
            panelArchivos.Controls.Add(buttonGuardar);
            panelArchivos.Controls.Add(Abrir);
            panelArchivos.Location = new Point(602, 7);
            panelArchivos.Name = "panelArchivos";
            panelArchivos.Size = new Size(199, 92);
            panelArchivos.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 4);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 11;
            label1.Text = "Archivos";
            // 
            // panelBD
            // 
            panelBD.BackColor = Color.Gainsboro;
            panelBD.BorderStyle = BorderStyle.FixedSingle;
            panelBD.Controls.Add(labelBaseDeDatos);
            panelBD.Controls.Add(buttonAbrirBaseDeDatos);
            panelBD.Location = new Point(397, 7);
            panelBD.Name = "panelBD";
            panelBD.Size = new Size(199, 92);
            panelBD.TabIndex = 16;
            // 
            // labelBaseDeDatos
            // 
            labelBaseDeDatos.AutoSize = true;
            labelBaseDeDatos.BackColor = Color.Black;
            labelBaseDeDatos.BorderStyle = BorderStyle.Fixed3D;
            labelBaseDeDatos.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelBaseDeDatos.ForeColor = Color.White;
            labelBaseDeDatos.Location = new Point(23, 4);
            labelBaseDeDatos.Name = "labelBaseDeDatos";
            labelBaseDeDatos.Size = new Size(153, 24);
            labelBaseDeDatos.TabIndex = 11;
            labelBaseDeDatos.Text = "Base De Datos";
            // 
            // buttonAbrirBaseDeDatos
            // 
            buttonAbrirBaseDeDatos.BackColor = SystemColors.ActiveCaption;
            buttonAbrirBaseDeDatos.FlatStyle = FlatStyle.Popup;
            buttonAbrirBaseDeDatos.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAbrirBaseDeDatos.ForeColor = Color.White;
            buttonAbrirBaseDeDatos.Location = new Point(44, 41);
            buttonAbrirBaseDeDatos.Name = "buttonAbrirBaseDeDatos";
            buttonAbrirBaseDeDatos.Size = new Size(115, 44);
            buttonAbrirBaseDeDatos.TabIndex = 7;
            buttonAbrirBaseDeDatos.Text = "Abrir";
            buttonAbrirBaseDeDatos.UseVisualStyleBackColor = false;
            buttonAbrirBaseDeDatos.Click += buttonAbrirBaseDeDatos_Click;
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.BackColor = Color.Gainsboro;
            labelTiempo.Font = new Font("Lucida Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTiempo.Location = new Point(9, 69);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(86, 24);
            labelTiempo.TabIndex = 17;
            labelTiempo.Text = "Tiempo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.reloj;
            pictureBox1.Location = new Point(18, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panelTiempo
            // 
            panelTiempo.BackColor = Color.Gainsboro;
            panelTiempo.BorderStyle = BorderStyle.FixedSingle;
            panelTiempo.Controls.Add(pictureBox1);
            panelTiempo.Controls.Add(labelTiempo);
            panelTiempo.Location = new Point(12, 385);
            panelTiempo.Name = "panelTiempo";
            panelTiempo.Size = new Size(123, 93);
            panelTiempo.TabIndex = 19;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 503);
            Controls.Add(panelBD);
            Controls.Add(panelArchivos);
            Controls.Add(buttonVisualizador);
            Controls.Add(comboBoxPrincipal);
            Controls.Add(listBoxPrincipal);
            Controls.Add(buttonDescendente);
            Controls.Add(buttonAscendente);
            Controls.Add(buttonModificar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(statusStrip1);
            Controls.Add(panelTiempo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioPrincipal";
            Text = "FormularioPrincipal";
            Load += FormularioPrincipal_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelArchivos.ResumeLayout(false);
            panelArchivos.PerformLayout();
            panelBD.ResumeLayout(false);
            panelBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTiempo.ResumeLayout(false);
            panelTiempo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonModificar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelOperador;
        private ToolStripStatusLabel toolStripStatusLabelFecha;
        private Button buttonGuardar;
        private Button Abrir;
        private Button buttonAscendente;
        private Button buttonDescendente;
        private ListBox listBoxPrincipal;
        private ComboBox comboBoxPrincipal;
        private Button buttonVisualizador;
        private Panel panelArchivos;
        private Label label1;
        private Panel panelBD;
        private Label labelBaseDeDatos;
        private Button buttonAbrirBaseDeDatos;
        private Label labelTiempo;
        private PictureBox pictureBox1;
        private Panel panelTiempo;
    }
}
