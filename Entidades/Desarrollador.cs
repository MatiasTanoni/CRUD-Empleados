using Entidades.Interfaces;

namespace Entidades
{
    public class Desarrollador : Empleado, IEmpleado<Empleado>
    {
        private string lenguajeDeProgramacion = string.Empty;
        private int proyectosFinalizados;

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

        /// <summary>
        /// Compara dos objetos Desarrollador para verificar si son iguales.
        /// </summary>
        /// <param name="desarrollador">Primer desarrollador a comparar.</param>
        /// <param name="desarrollador1">Segundo desarrollador a comparar.</param>
        /// <returns>True si ambos desarrolladores son iguales en salario, lenguaje de programación y proyectos finalizados; de lo contrario, false.</returns>
        public static bool operator ==(Desarrollador desarrollador, Desarrollador desarrollador1)
        {
            return desarrollador.Salario == desarrollador1.Salario && desarrollador.LenguajeDeProgramacion == desarrollador1.LenguajeDeProgramacion && desarrollador.ProyectosFinalizados == desarrollador1.ProyectosFinalizados;
        }

        /// <summary>
        /// Compara dos objetos Desarrollador para verificar si son diferentes.
        /// </summary>
        /// <param name="desarrollador">Primer desarrollador a comparar.</param>
        /// <param name="desarrollador1">Segundo desarrollador a comparar.</param>
        /// <returns>True si algún aspecto de los desarrolladores (salario, lenguaje de programación o proyectos finalizados) es diferente; de lo contrario, false.</returns>
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
            return 0;
        }
    }
}