using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gerente:Empleado
    {
        // Atributos
        private int salario;
        private int personasACargo;
        private int proyectosGestionados;
        // Constructor
        public Gerente(string nombre,int edad, int experiencia):base(nombre,edad,experiencia)
        {
        }
        public Gerente(int salario, string nombre, int edad, int experiencia) :this(nombre, edad, experiencia)
        {
            this.salario = salario;
        }
        public Gerente(int salario,int personasACargo, string nombre, int edad, int experiencia) :this(salario, nombre, edad, experiencia)
        {
            this.personasACargo = personasACargo;   
        }
        public Gerente(int salario, int personasACargo, int proyectosGestionados, string nombre, int edad, int experiencia) : this(salario,personasACargo, nombre, edad, experiencia)
        {
            this.proyectosGestionados = proyectosGestionados;
        }

        public override string MostrarInformacion()
        {
            return $"el nombre es {this.nombre}, la edad es: {this.edad}, el salario es:  {this.salario}, y esta a cargo de: {this.personasACargo} personas, Proyectos Gestionados: {proyectosGestionados}";
        }
    }
}
