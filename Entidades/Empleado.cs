namespace Entidades
{
    /// <summary>
    /// Clase abstracta que representa a un empleado.
    /// </summary>
    public abstract class Empleado
    {
        // Atributos
        protected string nombre;
        protected int edad;
        protected int experiencia;

        // Propiedades
        /// <summary>
        /// Obtiene o establece el nombre del empleado.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece la edad del empleado.
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        /// <summary>
        /// Obtiene o establece la experiencia del empleado.
        /// </summary>
        public int Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }

        // Constructor
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Empleado"/>.
        /// </summary>
        public Empleado()
        {
            this.nombre = "";
            this.edad = 0;
            this.experiencia = 0;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Empleado"/> con el nombre especificado.
        /// </summary>
        /// <param name="nombre">El nombre del empleado.</param>
        public Empleado(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Empleado"/> con el nombre y la edad especificados.
        /// </summary>
        /// <param name="nombre">El nombre del empleado.</param>
        /// <param name="edad">La edad del empleado.</param>
        public Empleado(string nombre, int edad) : this(nombre)
        {
            this.edad = edad;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Empleado"/> con el nombre, edad y experiencia especificados.
        /// </summary>
        /// <param name="nombre">El nombre del empleado.</param>
        /// <param name="edad">La edad del empleado.</param>
        /// <param name="experiencia">La experiencia del empleado.</param>
        public Empleado(string nombre, int edad, int experiencia) : this(nombre, edad)
        {
            this.experiencia = experiencia;
        }

        /// <summary>
        /// Método abstracto que devuelve la información del empleado.
        /// </summary>
        /// <returns>Información del empleado.</returns>
        public abstract string MostrarInformacion();


    }


}
