using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa un empleado de tipo Desarrollador en la empresa
    /// </summary>
    public class Desarrollador : Empleado
    {
        // Atributos
        private int salario;
        private string lenguajeDeProgramacion;
        private int proyectosFinalizados;

        // Propiedades
        /// <summary>
        /// Obtiene o establece el salario del desarrollador.
        /// </summary>
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

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
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Desarrollador"/>.
        /// </summary>
        /// <param name="nombre">El nombre del desarrollador.</param>
        /// <param name="edad">La edad del desarrollador.</param>
        /// <param name="experiencia">La experiencia del desarrollador.</param>
        public Desarrollador(string nombre, int edad, int experiencia) : base(nombre, edad, experiencia)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Desarrollador"/> con el salario especificado.
        /// </summary>
        /// <param name="salario">El salario del desarrollador.</param>
        /// <param name="nombre">El nombre del desarrollador.</param>
        /// <param name="edad">La edad del desarrollador.</param>
        /// <param name="experiencia">La experiencia del desarrollador.</param>
        public Desarrollador(int salario, string nombre, int edad, int experiencia) : this(nombre, edad, experiencia)
        {
            this.salario = salario;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Desarrollador"/> con el salario y lenguaje de programación especificados.
        /// </summary>
        /// <param name="salario">El salario del desarrollador.</param>
        /// <param name="lenguajeDeProgramacion">El lenguaje de programación que domina el desarrollador.</param>
        /// <param name="nombre">El nombre del desarrollador.</param>
        /// <param name="edad">La edad del desarrollador.</param>
        /// <param name="experiencia">La experiencia del desarrollador.</param>
        public Desarrollador(int salario, string lenguajeDeProgramacion, string nombre, int edad, int experiencia) : this(salario, nombre, edad, experiencia)
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
        public Desarrollador(int salario, string lenguajeDeProgramacion, int proyectosFinalizados, string nombre, int edad, int experiencia) : this(salario, lenguajeDeProgramacion, nombre, edad, experiencia)
        {
            this.proyectosFinalizados = proyectosFinalizados;
        }

        /// <summary>
        /// Devuelve la información del desarrollador.
        /// </summary>
        /// <returns>La información del desarrollador.</returns>
        public override string MostrarInformacion()
        {
            return $"Nombre: {this.nombre} - Edad: {this.edad} - Experiencia: {this.experiencia} - Salario: {this.salario} - Lenguaje De Programacion: {this.lenguajeDeProgramacion} - Proyectos finalizados: {this.proyectosFinalizados}";
        }
        //public override string ToString()
        //{
        //    return this.MostrarInformacion();
        //}
    }

}
