using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades
{
    /// <summary>
    /// Representa un empleado de tipo Desarrollador en la empresa
    /// </summary>
    public class Desarrollador : Empleado, IEmpleado<Empleado>
    {
        // Atributos
        /// <summary>
        ///Tipo de empleado
        ///Salario del empleado
        ///Lenguaje de programación que el empleado utiliza.
        ///Número de proyectos finalizados por el empleado.
        /// </summary>
        //private TipoDeEmpleados tipo;
        private string lenguajeDeProgramacion = string.Empty;
        private int proyectosFinalizados;

        // Propiedades
        //public TipoDeEmpleados Tipo
        //{
        //    get { return tipo; }
        //    set { tipo = value; }
        //}
        /// <summary>
        /// Obtiene o establece el lenguaje de programación que domina el desarrollador.
        /// </summary>
        public string LenguajeDeProgramacion
        {
            get { return lenguajeDeProgramacion; }
            set { lenguajeDeProgramacion = value; }

        }

        /// <summary>
        /// Obtiene o establece la cantidad de proyectos finalizados por el desarrollador.
        /// </summary>
        public int ProyectosFinalizados
        {
            get { return proyectosFinalizados; }
            set { proyectosFinalizados = value; }
        }

        // Constructor
        public Desarrollador()
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Desarrollador"/>.
        /// </summary>
        /// <param name="nombre">El nombre del desarrollador.</param>
        /// <param name="edad">La edad del desarrollador.</param>
        /// <param name="experiencia">La experiencia del desarrollador.</param>
        public Desarrollador(string nombre, int edad, int experiencia,int salario,TipoDeEmpleados tipo,int id) : base(nombre, edad, experiencia,salario,tipo,id)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Desarrollador"/> con el salario especificado.
        /// </summary>
        /// <param name="salario">El salario del desarrollador.</param>
        /// <param name="nombre">El nombre del desarrollador.</param>
        /// <param name="edad">La edad del desarrollador.</param>
        /// <param name="experiencia">La experiencia del desarrollador.</param>
        public Desarrollador(int salario, string nombre, int edad, int experiencia,TipoDeEmpleados tipo,int id) : this(nombre, edad, experiencia, salario, tipo, id)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Desarrollador"/> con el salario y lenguaje de programación especificados.
        /// </summary>
        /// <param name="salario">El salario del desarrollador.</param>
        /// <param name="lenguajeDeProgramacion">El lenguaje de programación que domina el desarrollador.</param>
        /// <param name="nombre">El nombre del desarrollador.</param>
        /// <param name="edad">La edad del desarrollador.</param>
        /// <param name="experiencia">La experiencia del desarrollador.</param>
        public Desarrollador(int salario, string lenguajeDeProgramacion, string nombre, int edad, int experiencia,TipoDeEmpleados tipo, int id) : this(salario, nombre, edad, experiencia,tipo, id)
        {
            this.lenguajeDeProgramacion = lenguajeDeProgramacion;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Desarrollador"/> con el salario, lenguaje de programación y proyectos finalizados especificados.
        /// </summary>
        /// <param name="salario">El salario del desarrollador.</param>
        /// <param name="lenguajeDeProgramacion">El lenguaje de programación que domina el desarrollador.</param>
        /// <param name="proyectosFinalizados">La cantidad de proyectos finalizados por el desarrollador.</param>
        /// <param name="nombre">El nombre del desarrollador.</param>
        /// <param name="edad">La edad del desarrollador.</param>
        /// <param name="experiencia">La experiencia del desarrollador.</param>
        public Desarrollador(int salario, string lenguajeDeProgramacion, int proyectosFinalizados, string nombre, int edad, int experiencia,TipoDeEmpleados tipo,int id) : this(salario, lenguajeDeProgramacion, nombre, edad, experiencia, tipo, id)
        {
            this.proyectosFinalizados = proyectosFinalizados;

        }
        public static bool operator ==(Desarrollador desarrollador, Desarrollador desarrollador1)
        {
            return desarrollador.Salario == desarrollador1.Salario && desarrollador.LenguajeDeProgramacion == desarrollador1.LenguajeDeProgramacion && desarrollador.ProyectosFinalizados == desarrollador1.ProyectosFinalizados;
        }

        public static bool operator !=(Desarrollador desarrollador, Desarrollador desarrollador1)
        {
            return desarrollador.Salario != desarrollador1.Salario && desarrollador.LenguajeDeProgramacion != desarrollador1.LenguajeDeProgramacion && desarrollador.ProyectosFinalizados != desarrollador1.ProyectosFinalizados;
        }
        /// <summary>
        /// Devuelve la información del desarrollador.
        /// </summary>
        /// <returns>La información del desarrollador.</returns>
        public override string MostrarInformacion()
        {
            return $"{this.tipo} - {base.ToString()} - {base.MostrarExperiencia()} - Salario: {this.salario} - Lenguaje De Programacion: {this.lenguajeDeProgramacion} - Proyectos finalizados: {this.proyectosFinalizados} - {ToString()}";
        }

        /// <summary>
        /// Devuelve una representación de cadena del objeto Desarrollador.
        /// </summary>
        /// <returns>Una cadena que representa el objeto Desarrollador.</returns>
        public override string ToString()
        {
            return "Información de un Desarrollador";
        }
        /// <summary>
        /// Comprueba si el objeto actual es igual a otro objeto Desarrollador.
        /// </summary>
        /// <param name="otroDesarrollador">El objeto que se va a comparar con el objeto actual.</param>
        /// <returns>True si el objeto actual es igual al objeto especificado; de lo contrario, False.</returns>
        public override bool Equals(Object? otroDesarrollador)
        {
            return otroDesarrollador is Desarrollador && this == (Desarrollador)otroDesarrollador;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

}
