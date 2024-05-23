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
            buttonCancelar = new Button();
            radioButtonDesarrollador = new RadioButton();
            groupBox = new GroupBox();
            radioButtonGerente = new RadioButton();
            radioButtonTester = new RadioButton();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(224, 224, 224);
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(125, 188);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(123, 62);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
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
            groupBox.Location = new Point(53, 64);
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
            radioButtonGerente.CheckedChanged += radioButtonGerente_CheckedChanged;
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
            radioButtonTester.CheckedChanged += radioButtonTester_CheckedChanged;
            // 
            // FormularioDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(372, 323);
            Controls.Add(groupBox);
            Controls.Add(buttonCancelar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCancelar;
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