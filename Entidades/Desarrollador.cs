using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Desarrollador : Empleado
    {
        // Atributos
        private int salario;
        private string lenguajeDeProgramacion;
        private int proyectosFinalizados;

        // Propiedades
        public int Salario
        {
            get { return salario; }
        }
        public string LeangueDeProgramacion
        {
            get { return lenguajeDeProgramacion;}
        }
        public int ProyectosFinalizados
        {
            get { return proyectosFinalizados;}
        }
        
        // Constructor
        public Desarrollador(string nombre,int edad,int experiencia):base(nombre,edad,experiencia)
        {
        }

        public Desarrollador(int salario, string nombre, int edad, int experiencia) :this(nombre,edad,experiencia)
        {
            this.salario = salario;
        }
        public Desarrollador(int salario, string lenguajeDeProgramacion, string nombre, int edad, int experiencia) :this(salario, nombre, edad, experiencia)
        {
            this.lenguajeDeProgramacion = lenguajeDeProgramacion;
        }
        public Desarrollador(int salario, string lenguajeDeProgramacion, int proyectosFinalizados,string nombre,int edad, int experiencia) : this(salario,lenguajeDeProgramacion, nombre, edad, experiencia)
        {
            this.proyectosFinalizados = proyectosFinalizados;
        }
        public override string MostrarInformacion()
        {     
            return $"Nombre: {this.nombre},Edad: {this.edad},Salario: {this.salario}, lenguaje de programacion: {this.lenguajeDeProgramacion},Proyectos finalizados: {proyectosFinalizados}";     
        }
    }
}
