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
            listBoxPrincipal = new ListBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelOperador = new ToolStripStatusLabel();
            toolStripStatusLabelFecha = new ToolStripStatusLabel();
            buttonVisualizador = new Button();
            buttonGuardar = new Button();
            Abrir = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPrincipal
            // 
            listBoxPrincipal.BackColor = Color.Silver;
            listBoxPrincipal.Font = new Font("Lucida Sans", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBoxPrincipal.FormattingEnabled = true;
            listBoxPrincipal.ItemHeight = 15;
            listBoxPrincipal.Location = new Point(12, 32);
            listBoxPrincipal.Name = "listBoxPrincipal";
            listBoxPrincipal.Size = new Size(776, 304);
            listBoxPrincipal.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.OliveDrab;
            buttonAgregar.FlatStyle = FlatStyle.Popup;
            buttonAgregar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(74, 342);
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
            buttonEliminar.Location = new Point(601, 342);
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
            buttonModificar.Location = new Point(348, 342);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(127, 62);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelOperador, toolStripStatusLabelFecha });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
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
            // buttonVisualizador
            // 
            buttonVisualizador.BackColor = Color.Black;
            buttonVisualizador.FlatStyle = FlatStyle.Popup;
            buttonVisualizador.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVisualizador.ForeColor = Color.White;
            buttonVisualizador.Location = new Point(12, 3);
            buttonVisualizador.Name = "buttonVisualizador";
            buttonVisualizador.Size = new Size(114, 23);
            buttonVisualizador.TabIndex = 5;
            buttonVisualizador.Text = "Visualizador";
            buttonVisualizador.UseVisualStyleBackColor = false;
            buttonVisualizador.Click += buttonVisualizador_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.OliveDrab;
            buttonGuardar.FlatStyle = FlatStyle.Popup;
            buttonGuardar.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuardar.ForeColor = Color.White;
            buttonGuardar.Location = new Point(699, 3);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(89, 23);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // Abrir
            // 
            Abrir.BackColor = SystemColors.ActiveCaption;
            Abrir.FlatStyle = FlatStyle.Popup;
            Abrir.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Abrir.ForeColor = Color.White;
            Abrir.Location = new Point(604, 3);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(89, 23);
            Abrir.TabIndex = 7;
            Abrir.Text = "Abrir";
            Abrir.UseVisualStyleBackColor = false;
            Abrir.Click += Abrir_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Abrir);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonVisualizador);
            Controls.Add(statusStrip1);
            Controls.Add(buttonModificar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(listBoxPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipal";
            Load += FormularioPrincipal_Load_1;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPrincipal;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonModificar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelOperador;
        private ToolStripStatusLabel toolStripStatusLabelFecha;
        private Button buttonVisualizador;
        private Button buttonGuardar;
        private Button Abrir;
    }
}
