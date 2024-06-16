namespace Formularios
{
    partial class FormBase
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
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.autoscalemode = system.windows.forms.autoscalemode.font;
            //this.clientsize = new system.drawing.size(800, 450);
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.ResumeLayout(false);
        }
    }
}