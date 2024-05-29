namespace Entidades
{
    /// <summary>
    /// Clase abstracta que representa a un empleado.
    /// </summary>
    public abstract class Empleado
    {
        // Atributos
        /// <summary>
        /// Nombre del empleado.
        /// Edad del empleado.
        /// Experiencia del empleado en años.
        /// </summary>
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

        /// <summary>
        /// Comprueba si el objeto actual es igual a otro objeto Empleado.
        /// </summary>
        /// <param name="otroEmpleado">El objeto que se va a comparar con el objeto actual.</param>
        /// <returns>True si el objeto actual es igual al objeto especificado; de lo contrario, False.</returns>
        public override bool Equals(Object otroEmpleado)
        {
            return otroEmpleado is Empleado && this == (Empleado)otroEmpleado;
        }
        /// <summary>
        /// Devuelve una representación de cadena del objeto Empleado.
        /// </summary>
        /// <returns>Una cadena que representa el objeto Empleado.</returns>
        public virtual string ToString()
        {
            return "Soy Empleado";
        }
    }


}
