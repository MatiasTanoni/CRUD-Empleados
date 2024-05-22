namespace Formularios
{
    partial class FormularioDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDatos));
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            menuStrip1 = new MenuStrip();
            radioButtonDesarrollador = new RadioButton();
            groupBox = new GroupBox();
            radioButtonGerente = new RadioButton();
            radioButtonTester = new RadioButton();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.FromArgb(224, 224, 224);
            buttonAceptar.FlatStyle = FlatStyle.Popup;
            buttonAceptar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAceptar.Location = new Point(46, 200);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(127, 62);
            buttonAceptar.TabIndex = 3;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = false;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(224, 224, 224);
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(186, 200);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(123, 62);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(372, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // radioButtonDesarrollador
            // 
            radioButtonDesarrollador.AutoSize = true;
            radioButtonDesarrollador.Location = new Point(6, 23);
            radioButtonDesarrollador.Name = "radioButtonDesarrollador";
            radioButtonDesarrollador.Size = new Size(136, 22);
            radioButtonDesarrollador.TabIndex = 9;
            radioButtonDesarrollador.TabStop = true;
            radioButtonDesarrollador.Text = "Desarrollador";
            radioButtonDesarrollador.UseVisualStyleBackColor = true;
            radioButtonDesarrollador.CheckedChanged += radioButtonDesarrollador_CheckedChanged;
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.FromArgb(224, 224, 224);
            groupBox.Controls.Add(radioButtonGerente);
            groupBox.Controls.Add(radioButtonTester);
            groupBox.Controls.Add(radioButtonDesarrollador);
            groupBox.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.ForeColor = SystemColors.ControlText;
            groupBox.Location = new Point(46, 63);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(263, 107);
            groupBox.TabIndex = 12;
            groupBox.TabStop = false;
            groupBox.Text = "Elegir Empleado";
            // 
            // radioButtonGerente
            // 
            radioButtonGerente.AutoSize = true;
            radioButtonGerente.Location = new Point(6, 73);
            radioButtonGerente.Name = "radioButtonGerente";
            radioButtonGerente.Size = new Size(91, 22);
            radioButtonGerente.TabIndex = 11;
            radioButtonGerente.TabStop = true;
            radioButtonGerente.Text = "Gerente";
            radioButtonGerente.UseVisualStyleBackColor = true;
            // 
            // radioButtonTester
            // 
            radioButtonTester.AutoSize = true;
            radioButtonTester.Location = new Point(6, 48);
            radioButtonTester.Name = "radioButtonTester";
            radioButtonTester.Size = new Size(78, 22);
            radioButtonTester.TabIndex = 10;
            radioButtonTester.TabStop = true;
            radioButtonTester.Text = "Tester";
            radioButtonTester.UseVisualStyleBackColor = true;
            // 
            // FormularioDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(372, 323);
            Controls.Add(groupBox);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAceptar);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormularioDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAceptar;
        private Button buttonCancelar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadoToolStripMenuItem;
        private ToolStripMenuItem gerenteToolStripMenuItem;
        private ToolStripMenuItem testerToolStripMenuItem;
        private ToolStripMenuItem desarrolladorToolStripMenuItem;
        private RadioButton radioButtonDesarrollador;
        private GroupBox groupBox;
        private RadioButton radioButtonGerente;
        private RadioButton radioButtonTester;
    }
}