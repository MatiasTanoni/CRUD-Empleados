namespace Formularios
{
    partial class FormConfiguraciones
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(224, 224, 224);
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(409, 416);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(131, 64);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // FormConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonCancelar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormConfiguraciones";
            Text = "FormBase";
            ResumeLayout(false);
        }

        private Button buttonCancelar;
    }
}