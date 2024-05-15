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
            return $"Nombre: {this.nombre}, Edad: {this.edad},Salario: {this.salario}, Herramienta De Prueba: {this.herramientaDePrueba}, Testeo: {this.proyectosTesteados} proyectos";
        }
    }
   
}
