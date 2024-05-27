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
            SuspendLayout();
            // 
            // listBoxPrincipal
            // 
            listBoxPrincipal.BackColor = Color.Silver;
            listBoxPrincipal.Font = new Font("Lucida Sans", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBoxPrincipal.FormattingEnabled = true;
            listBoxPrincipal.ItemHeight = 15;
            listBoxPrincipal.Location = new Point(12, 30);
            listBoxPrincipal.Name = "listBoxPrincipal";
            listBoxPrincipal.Size = new Size(776, 304);
            listBoxPrincipal.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.OliveDrab;
            buttonAgregar.FlatStyle = FlatStyle.Popup;
            buttonAgregar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(84, 360);
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
            buttonEliminar.Location = new Point(616, 360);
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
            buttonModificar.Location = new Point(350, 360);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(127, 62);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModificar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(listBoxPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPrincipal;
        private Button buttonAgregar;
        private Button buttonEliminar;
        private Button buttonModificar;
    }
}
