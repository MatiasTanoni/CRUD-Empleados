namespace Formularios
{
    partial class FormVisualizador 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizador));
            buttonVolver = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            richTextBoxVisualizador = new RichTextBox();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Gray;
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVolver.Location = new Point(290, 419);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(127, 62);
            buttonVolver.TabIndex = 3;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // richTextBoxVisualizador
            // 
            richTextBoxVisualizador.BackColor = Color.Silver;
            richTextBoxVisualizador.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxVisualizador.Location = new Point(12, 12);
            richTextBoxVisualizador.Name = "richTextBoxVisualizador";
            richTextBoxVisualizador.Size = new Size(687, 389);
            richTextBoxVisualizador.TabIndex = 4;
            richTextBoxVisualizador.Text = "";
            // 
            // FormVisualizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(711, 519);
            Controls.Add(richTextBoxVisualizador);
            Controls.Add(buttonVolver);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVisualizador";
            Text = "Visualizador";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVolver;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox richTextBoxVisualizador;
    }
}