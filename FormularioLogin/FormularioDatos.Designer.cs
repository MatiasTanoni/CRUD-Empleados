
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
            panel1 = new Panel();
            labelElegirEmpleado = new Label();
            groupBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(224, 224, 224);
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(117, 232);
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
            radioButtonDesarrollador.TabIndex = 1;
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
            groupBox.FlatStyle = FlatStyle.Flat;
            groupBox.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.ForeColor = SystemColors.ControlText;
            groupBox.Location = new Point(49, 93);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(263, 116);
            groupBox.TabIndex = 12;
            groupBox.TabStop = false;
            // 
            // radioButtonGerente
            // 
            radioButtonGerente.AutoSize = true;
            radioButtonGerente.Location = new Point(6, 73);
            radioButtonGerente.Name = "radioButtonGerente";
            radioButtonGerente.Size = new Size(91, 22);
            radioButtonGerente.TabIndex = 3;
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
            radioButtonTester.TabIndex = 2;
            radioButtonTester.TabStop = true;
            radioButtonTester.Text = "Tester";
            radioButtonTester.UseVisualStyleBackColor = true;
            radioButtonTester.CheckedChanged += radioButtonTester_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelElegirEmpleado);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 63);
            panel1.TabIndex = 134;
            // 
            // labelElegirEmpleado
            // 
            labelElegirEmpleado.AutoSize = true;
            labelElegirEmpleado.BackColor = Color.Black;
            labelElegirEmpleado.BorderStyle = BorderStyle.Fixed3D;
            labelElegirEmpleado.Font = new Font("Lucida Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelElegirEmpleado.ForeColor = Color.White;
            labelElegirEmpleado.Location = new Point(42, 13);
            labelElegirEmpleado.Name = "labelElegirEmpleado";
            labelElegirEmpleado.Size = new Size(260, 35);
            labelElegirEmpleado.TabIndex = 11;
            labelElegirEmpleado.Text = "Elegir Empleado";
            // 
            // FormularioDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(372, 323);
            Controls.Add(panel1);
            Controls.Add(groupBox);
            Controls.Add(buttonCancelar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioDatos";
            Text = "Agregar";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCancelar;
        //private ToolStripMenuItem empleadoToolStripMenuItem;
        //private ToolStripMenuItem gerenteToolStripMenuItem;
        //private ToolStripMenuItem testerToolStripMenuItem;
        //private ToolStripMenuItem desarrolladorToolStripMenuItem;
        private RadioButton radioButtonDesarrollador;
        private GroupBox groupBox;
        private RadioButton radioButtonGerente;
        private RadioButton radioButtonTester;
        private Panel panel1;
        private Label labelElegirEmpleado;
    }
}