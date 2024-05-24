using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tester : Empleado
    {   
        // Atributos
        private int salario;
        private string herramientaDePrueba;
        private int proyectosTesteados;

        //Propiedades
        public int Salario
        {
            set { salario = value; }
            get { return salario; }
        }
        public string HerramientaDePrueba
        {
            set { herramientaDePrueba = value; }
            get { return herramientaDePrueba;}
        }
        public int ProyectosTesteados
        {
            set { proyectosTesteados = value; }
            get { return proyectosTesteados; }
        }


        // Constructor
        public Tester(string nombre,int edad, int experiencia) : base(nombre,edad,experiencia)
        {       
            
        }

        public Tester(int salario,string nombre,int edad, int experiencia):this(nombre,edad,experiencia)
        {
            this.salario = salario;
        }
        public Tester(int salario,string herramientaDePrueba,string nombre, int edad, int experiencia):this(salario,nombre,edad,experiencia) 
        {
            this.herramientaDePrueba = herramientaDePrueba;
        }

        public Tester(int salario, string herramientaDePrueba,int proyectosTesteados,string nombre,int edad,int experiencia) : this(salario,herramientaDePrueba,nombre,edad,experiencia) 
        {
            this.proyectosTesteados = proyectosTesteados;
        }


        public override string MostrarInformacion()
        {
            return $"Nombre: {this.nombre} - Edad: {this.edad} - Experiencia: {this.experiencia} - Salario: {this.salario} - Herramienta De Prueba: {this.herramientaDePrueba} - Testeo: {this.proyectosTesteados} proyectos";
        }
        //public override string ToString()
        //{
        //    return this.MostrarInformacion();
        //}
    }

}
