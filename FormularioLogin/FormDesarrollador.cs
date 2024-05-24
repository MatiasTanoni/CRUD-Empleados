using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios;

namespace Formularios
{
    public partial class FormDesarrollador : Form
    {
        public Empresa empresa;
        public Desarrollador desarrollador;
        public FormDesarrollador()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.empresa = new Empresa();
            this.desarrollador = new Desarrollador("", 0, 0);
            this.desarrollador.Nombre = this.textBoxNombre.Text;
            this.desarrollador.Experiencia = int.Parse(this.textBoxExperiencia.Text);
            this.desarrollador.Salario = int.Parse(this.textBoxSalario.Text);
            this.desarrollador.LenguajeDeProgramacion = this.textBoxLenguajeDeProgramacion.Text;
            this.desarrollador.ProyectosFinalizados = int.Parse(this.textBoxProyectosFinalizados.Text);


            if (int.TryParse(this.textBoxEdad.Text, out _))
            {
                if (int.Parse(this.textBoxEdad.Text) > 0 && int.Parse(this.textBoxEdad.Text) < 90)
                {
                    this.desarrollador.Edad = int.Parse(this.textBoxEdad.Text); 
                    this.empresa.listaDeEmpleados.Add(this.desarrollador);
                    this.DialogResult = DialogResult.OK;
                    //this.FormularioDatos.Hide();
                }
                else
                {
                    MessageBox.Show("edad inexistente");
                }
            }
            else
            {
                MessageBox.Show("mal ingresado, no has ingresado un numero");
            }

    }
        //private void ValidarIngresosDesarrollador(TextBox textBoxNombre_, TextBox textBoxEdad_, TextBox textBoxExperiencia_,TextBox textBoxSalario_, TextBox textBoxLenguajeDeProgramacion_, TextBox textBoxProyectosFinalizados_, Empresa empresaa, Desarrollador desarrolladorr)
        //{
        //    empresaa = new Empresa();
        //    desarrolladorr = new Desarrollador("", 0, 0);

        //    desarrolladorr.Nombre = textBoxNombre_.Text;
        //    desarrolladorr.Experiencia = int.Parse(textBoxExperiencia_.Text);
        //    desarrolladorr.Salario = int.Parse(textBoxSalario_.Text);
        //    desarrolladorr.LenguajeDeProgramacion = textBoxLenguajeDeProgramacion_.Text;
        //    desarrolladorr.ProyectosFinalizados = int.Parse(textBoxProyectosFinalizados_.Text);

        //    if (int.TryParse(textBoxEdad_.Text, out _))
        //    {
        //        if (int.Parse(textBoxEdad_.Text) > 0 && int.Parse(textBoxEdad_.Text) < 90)
        //        {
        //            desarrolladorr.Edad = int.Parse(textBoxEdad_.Text);
        //            empresaa.listaDeEmpleados.Add(desarrolladorr);
        //            //DialogResult = DialogResult.Cancel;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Edad Inexistente");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Mal Ingresado, no has ingresado un numero");
        //    }
        //}
    }
}
