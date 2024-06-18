namespace Formularios
{
    partial class FormularioLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLogin));
            pContainer = new Panel();
            buttonContraseña = new Button();
            pictureBox2 = new PictureBox();
            buttonIniciarSesion = new Button();
            labelContrasena = new Label();
            textContrasena = new TextBox();
            pictureBoxContrasena = new PictureBox();
            labelCorreo = new Label();
            textBoxCorreo = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBoxCorreo = new PictureBox();
            pictureBoxBorderCorreo = new PictureBox();
            pictureBoxBorderContrasena = new PictureBox();
            pictureBoxIniciarSesion = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrasena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderContrasena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIniciarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pContainer
            // 
            pContainer.BackColor = Color.White;
            pContainer.Controls.Add(buttonContraseña);
            pContainer.Controls.Add(pictureBox2);
            pContainer.Controls.Add(buttonIniciarSesion);
            pContainer.Controls.Add(labelContrasena);
            pContainer.Controls.Add(textContrasena);
            pContainer.Controls.Add(pictureBoxContrasena);
            pContainer.Controls.Add(labelCorreo);
            pContainer.Controls.Add(textBoxCorreo);
            pContainer.Controls.Add(pictureBox1);
            pContainer.Controls.Add(pictureBoxCorreo);
            pContainer.Controls.Add(pictureBoxBorderCorreo);
            pContainer.Controls.Add(pictureBoxBorderContrasena);
            pContainer.Controls.Add(pictureBoxIniciarSesion);
            pContainer.Controls.Add(pictureBox3);
            pContainer.Controls.Add(panel1);
            pContainer.Dock = DockStyle.Fill;
            pContainer.Location = new Point(0, 0);
            pContainer.Name = "pContainer";
            pContainer.Size = new Size(455, 458);
            pContainer.TabIndex = 0;
            // 
            // buttonContraseña
            // 
            buttonContraseña.BackColor = Color.Gainsboro;
            buttonContraseña.FlatAppearance.BorderColor = Color.Black;
            buttonContraseña.FlatStyle = FlatStyle.Popup;
            buttonContraseña.Location = new Point(398, 209);
            buttonContraseña.Name = "buttonContraseña";
            buttonContraseña.Size = new Size(47, 44);
            buttonContraseña.TabIndex = 15;
            buttonContraseña.UseVisualStyleBackColor = false;
            buttonContraseña.Click += buttonContraseña_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gainsboro;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.FlatStyle = FlatStyle.Popup;
            buttonIniciarSesion.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonIniciarSesion.Location = new Point(154, 341);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(145, 71);
            buttonIniciarSesion.TabIndex = 2;
            buttonIniciarSesion.Text = "Iniciar Sesión";
            buttonIniciarSesion.UseVisualStyleBackColor = true;
            buttonIniciarSesion.Click += buttonIniciarSesion_Click;
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.BackColor = Color.White;
            labelContrasena.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelContrasena.ForeColor = Color.Black;
            labelContrasena.Location = new Point(130, 198);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(106, 18);
            labelContrasena.TabIndex = 8;
            labelContrasena.Text = "Contraseña:";
            // 
            // textContrasena
            // 
            textContrasena.BorderStyle = BorderStyle.None;
            textContrasena.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textContrasena.Location = new Point(130, 219);
            textContrasena.Name = "textContrasena";
            textContrasena.PasswordChar = '*';
            textContrasena.Size = new Size(254, 25);
            textContrasena.TabIndex = 1;
            textContrasena.Tag = "Correo";
            textContrasena.TextChanged += textContrasena_TextChanged;
            // 
            // pictureBoxContrasena
            // 
            pictureBoxContrasena.BackColor = Color.White;
            pictureBoxContrasena.Location = new Point(123, 205);
            pictureBoxContrasena.Name = "pictureBoxContrasena";
            pictureBoxContrasena.Size = new Size(267, 53);
            pictureBoxContrasena.TabIndex = 6;
            pictureBoxContrasena.TabStop = false;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.BackColor = Color.White;
            labelCorreo.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorreo.ForeColor = Color.Black;
            labelCorreo.Location = new Point(138, 115);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(67, 18);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo:";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCorreo.Location = new Point(130, 136);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(254, 25);
            textBoxCorreo.TabIndex = 0;
            textBoxCorreo.Tag = "Correo";
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(124, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 53);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxCorreo
            // 
            pictureBoxCorreo.BackColor = Color.White;
            pictureBoxCorreo.Location = new Point(124, 124);
            pictureBoxCorreo.Name = "pictureBoxCorreo";
            pictureBoxCorreo.Size = new Size(267, 53);
            pictureBoxCorreo.TabIndex = 1;
            pictureBoxCorreo.TabStop = false;
            // 
            // pictureBoxBorderCorreo
            // 
            pictureBoxBorderCorreo.BackColor = Color.Black;
            pictureBoxBorderCorreo.Location = new Point(122, 122);
            pictureBoxBorderCorreo.Name = "pictureBoxBorderCorreo";
            pictureBoxBorderCorreo.Size = new Size(271, 57);
            pictureBoxBorderCorreo.TabIndex = 2;
            pictureBoxBorderCorreo.TabStop = false;
            // 
            // pictureBoxBorderContrasena
            // 
            pictureBoxBorderContrasena.BackColor = Color.Black;
            pictureBoxBorderContrasena.Location = new Point(121, 203);
            pictureBoxBorderContrasena.Name = "pictureBoxBorderContrasena";
            pictureBoxBorderContrasena.Size = new Size(271, 57);
            pictureBoxBorderContrasena.TabIndex = 7;
            pictureBoxBorderContrasena.TabStop = false;
            // 
            // pictureBoxIniciarSesion
            // 
            pictureBoxIniciarSesion.BackColor = Color.Black;
            pictureBoxIniciarSesion.Location = new Point(149, 337);
            pictureBoxIniciarSesion.Name = "pictureBoxIniciarSesion";
            pictureBoxIniciarSesion.Size = new Size(154, 78);
            pictureBoxIniciarSesion.TabIndex = 10;
            pictureBoxIniciarSesion.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.candado1;
            pictureBox3.Location = new Point(46, 203);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 72);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Lucida Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 35);
            label1.TabIndex = 11;
            label1.Text = "Login";
            // 
            // FormularioLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 458);
            Controls.Add(pContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioLogin";
            Text = "Login";
            pContainer.ResumeLayout(false);
            pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrasena).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderContrasena).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIniciarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pContainer;
        private PictureBox pictureBoxCorreo;
        private PictureBox pictureBoxBorderCorreo;
        private TextBox textBoxCorreo;
        private Label labelCorreo;
        private Label labelContrasena;
        private TextBox textContrasena;
        private PictureBox pictureBoxContrasena;
        private PictureBox pictureBoxBorderContrasena;
        private PictureBox pictureBox1;
        private Button buttonIniciarSesion;
        private PictureBox pictureBoxIniciarSesion;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button buttonContraseña;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}