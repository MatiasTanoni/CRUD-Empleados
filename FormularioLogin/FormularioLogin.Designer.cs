﻿namespace Formularios
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
            label1 = new Label();
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
            pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrasena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderContrasena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIniciarSesion).BeginInit();
            SuspendLayout();
            // 
            // pContainer
            // 
            pContainer.BackColor = Color.White;
            pContainer.Controls.Add(label1);
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
            pContainer.Dock = DockStyle.Fill;
            pContainer.Location = new Point(0, 0);
            pContainer.Name = "pContainer";
            pContainer.Size = new Size(455, 458);
            pContainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Lucida Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 33);
            label1.TabIndex = 11;
            label1.Text = "LOGIN";
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
            labelContrasena.Location = new Point(19, 170);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(106, 18);
            labelContrasena.TabIndex = 8;
            labelContrasena.Text = "Contraseña:";
            // 
            // textContrasena
            // 
            textContrasena.BorderStyle = BorderStyle.None;
            textContrasena.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textContrasena.Location = new Point(24, 191);
            textContrasena.Name = "textContrasena";
            textContrasena.PasswordChar = '*';
            textContrasena.Size = new Size(242, 25);
            textContrasena.TabIndex = 1;
            textContrasena.Tag = "Correo";
            textContrasena.TextChanged += textContrasena_TextChanged;
            // 
            // pictureBoxContrasena
            // 
            pictureBoxContrasena.BackColor = Color.White;
            pictureBoxContrasena.Location = new Point(12, 177);
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
            labelCorreo.Location = new Point(27, 87);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(67, 18);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo:";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCorreo.Location = new Point(19, 108);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(254, 25);
            textBoxCorreo.TabIndex = 0;
            textBoxCorreo.Tag = "Correo";
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(13, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 53);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxCorreo
            // 
            pictureBoxCorreo.BackColor = Color.White;
            pictureBoxCorreo.Location = new Point(13, 96);
            pictureBoxCorreo.Name = "pictureBoxCorreo";
            pictureBoxCorreo.Size = new Size(267, 53);
            pictureBoxCorreo.TabIndex = 1;
            pictureBoxCorreo.TabStop = false;
            // 
            // pictureBoxBorderCorreo
            // 
            pictureBoxBorderCorreo.BackColor = Color.Black;
            pictureBoxBorderCorreo.Location = new Point(11, 94);
            pictureBoxBorderCorreo.Name = "pictureBoxBorderCorreo";
            pictureBoxBorderCorreo.Size = new Size(271, 57);
            pictureBoxBorderCorreo.TabIndex = 2;
            pictureBoxBorderCorreo.TabStop = false;
            // 
            // pictureBoxBorderContrasena
            // 
            pictureBoxBorderContrasena.BackColor = Color.Black;
            pictureBoxBorderContrasena.Location = new Point(10, 175);
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
            // FormularioLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 458);
            Controls.Add(pContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormularioLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            pContainer.ResumeLayout(false);
            pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrasena).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBorderContrasena).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIniciarSesion).EndInit();
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
    }
}