using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta que representa a un empleado.
    /// </summary>

    [XmlInclude(typeof(Empleado))]
    [XmlInclude(typeof(Desarrollador))]
    [XmlInclude(typeof(Tester))]
    [XmlInclude(typeof(Gerente))]

    public abstract class Empleado
    {

        protected int id; 
        protected string nombre = string.Empty;
        protected int edad;
        protected int experiencia;
        protected int salario;
        protected int edadJubilacionDefault = 65;
        protected TipoDeEmpleados tipo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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

        /// <summary>
        /// Obtiene o establece el salario del empleado.
        /// </summary>
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        /// <summary>
        /// Obtiene o establece la edad de jubilacion del empleado.
        /// </summary>
        public int EdadJubilacionDefault
        {
            get { return edadJubilacionDefault; }
        }

        /// <summary>
        /// Obtiene o establece el tipo de empleado.
        /// </summary>
        public TipoDeEmpleados Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Empleado()
        {
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
        /// Constructor de la clase Empleado que inicializa todas las propiedades.
        /// </summary>
        /// <param name="nombre">Nombre del empleado.</param>
        /// <param name="edad">Edad del empleado.</param>
        /// <param name="experiencia">Experiencia en años del empleado.</param>
        /// <param name="salario">Salario del empleado.</param>
        /// <param name="tipo">Tipo de empleado (por ejemplo, Tester, Desarrollador, Gerente).</param>
        /// <param name="id">Identificador único del empleado.</param>
        public Empleado(string nombre, int edad, int experiencia,int salario, TipoDeEmpleados tipo,int id) : this(nombre, edad, experiencia)
        {
            this.salario = salario;
            Tipo = tipo;
            this.id = id;
        }

        /// <summary>
        /// Calcula los años restantes hasta la jubilación usando la edad de jubilación predeterminada.
        /// </summary>
        /// <returns>Años restantes hasta la jubilación.</returns>
        public int AniosHastaJubilacion()
        {
            return AniosHastaJubilacion(EdadJubilacionDefault);
        }

        /// <summary>
        /// Método que calcula los años restantes hasta la jubilación del empleado.
        /// </summary>
        /// <param name="edadJubilacion">Edad de jubilación esperada.</param>
        /// <returns>Años restantes hasta la jubilación.</returns>
        public int AniosHastaJubilacion(int edadJubilacion)
        {
            return edadJubilacion - Edad;
        }

        /// <summary>
        /// Método abstracto que devuelve la información del empleado.
        /// </summary>
        /// <returns>Información del empleado.</returns>
        public abstract string MostrarInformacion();

        /// <summary>
        /// Retorna una cadena que representa la experiencia del empleado.
        /// </summary>
        /// <returns>Cadena que indica la experiencia del empleado.</returns>
        public virtual string MostrarExperiencia()
        {
            return $"Experiencia: {Experiencia}";
        }

        /// <summary>
        /// Devuelve una representación de cadena del objeto Empleado.
        /// </summary>
        /// <returns>Una cadena que representa el objeto Empleado.</returns>
        public override string ToString()
        {
            return $"Nombre: {Nombre} - Edad: {Edad} - Años para jubilacion: {AniosHastaJubilacion()}";
        }

        /// <summary>
        /// Comprueba si el objeto actual es igual a otro objeto Empleado.
        /// </summary>
        /// <param name="otroEmpleado">El objeto que se va a comparar con el objeto actual.</param>
        /// <returns>True si el objeto actual es igual al objeto especificado; de lo contrario, False.</returns>
        public override bool Equals(object? otroEmpleado)
        {

            return otroEmpleado is Empleado && this == (Empleado)otroEmpleado;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

    }
}