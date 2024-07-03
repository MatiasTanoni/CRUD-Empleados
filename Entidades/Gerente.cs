using Entidades.Interfaces;

namespace Entidades
{
    public class Gerente : Empleado, IEmpleado<Gerente>
    {
        private new TipoDeEmpleados tipo;
        private int personasACargo;
        private int proyectosGestionados;

        /// <summary>
        /// Tipo de empleado.
        /// </summary>
        public new TipoDeEmpleados Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de personas a cargo del gerente.
        /// </summary>
        public int PersonasACargo
        {
            get { return personasACargo; }
            set { personasACargo = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de proyectos gestionados por el gerente.
        /// </summary>
        public int ProyectosGestionados
        {
            get { return proyectosGestionados; }
            set { proyectosGestionados = value; }
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/>.
        /// </summary>
        public Gerente()
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/>.
        /// </summary>
        /// <param name="nombre">El nombre del gerente.</param>
        /// <param name="edad">La edad del gerente.</param>
        /// <param name="experiencia">La experiencia del gerente.</param>
        public Gerente(string nombre, int edad, int experiencia, int salario, TipoDeEmpleados tipo, int id) : base(nombre, edad, experiencia, salario, tipo, id)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/> con el salario especificado.
        /// </summary>
        /// <param name="salario">El salario del gerente.</param>
        /// <param name="nombre">El nombre del gerente.</param>
        /// <param name="edad">La edad del gerente.</param>
        /// <param name="experiencia">La experiencia del gerente.</param>
        public Gerente(int salario, string nombre, int edad, int experiencia, TipoDeEmpleados tipo, int id) : this(nombre, edad, experiencia, salario, tipo, id)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/> con el salario y la cantidad de personas a cargo especificados.
        /// </summary>
        /// <param name="salario">El salario del gerente.</param>
        /// <param name="personasACargo">La cantidad de personas a cargo del gerente.</param>
        /// <param name="nombre">El nombre del gerente.</param>
        /// <param name="edad">La edad del gerente.</param>
        /// <param name="experiencia">La experiencia del gerente.</param>
        public Gerente(int salario, int personasACargo, string nombre, int edad, int experiencia, TipoDeEmpleados tipo, int id) : this(salario, nombre, edad, experiencia, tipo, id)
        {
            this.personasACargo = personasACargo;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/> con el salario, la cantidad de personas a cargo y la cantidad de proyectos gestionados especificados.
        /// </summary>
        /// <param name="salario">El salario del gerente.</param>
        /// <param name="personasACargo">La cantidad de personas a cargo del gerente.</param>
        /// <param name="proyectosGestionados">La cantidad de proyectos gestionados por el gerente.</param>
        /// <param name="nombre">El nombre del gerente.</param>
        /// <param name="edad">La edad del gerente.</param>
        /// <param name="experiencia">La experiencia del gerente.</param>
        public Gerente(int salario, int personasACargo, int proyectosGestionados, string nombre, int edad, int experiencia, TipoDeEmpleados tipo, int id) : this(salario, personasACargo, nombre, edad, experiencia, tipo, id)
        {
            this.proyectosGestionados = proyectosGestionados;
        }

        /// <summary>
        /// Compara dos objetos Gerente para determinar si son iguales basándose en el salario, personas a cargo y proyectos gestionados.
        /// </summary>
        /// <param name="gerente">Primer objeto Gerente a comparar.</param>
        /// <param name="gerente1">Segundo objeto Gerente a comparar.</param>
        /// <returns>True si ambos objetos Gerente son iguales; False en caso contrario.</returns>
        public static bool operator ==(Gerente gerente, Gerente gerente1)
        {
            return gerente.Salario == gerente1.Salario && gerente.PersonasACargo == gerente1.PersonasACargo && gerente.ProyectosGestionados == gerente1.ProyectosGestionados;
        }

        /// <summary>
        /// Compara dos objetos Gerente para determinar si son diferentes basándose en el salario, personas a cargo y proyectos gestionados.
        /// </summary>
        /// <param name="gerente">Primer objeto Gerente a comparar.</param>
        /// <param name="gerente1">Segundo objeto Gerente a comparar.</param>
        /// <returns>True si los objetos Gerente son diferentes; False si son iguales.</returns>
        public static bool operator !=(Gerente gerente, Gerente gerente1)
        {
            return gerente.Salario != gerente1.Salario && gerente.PersonasACargo != gerente1.PersonasACargo && gerente.ProyectosGestionados != gerente1.ProyectosGestionados;
        }

        /// <summary>
        /// Devuelve la información del gerente.
        /// </summary>
        /// <returns>La información del gerente.</returns>
        public override string MostrarInformacion()
        {
            return $"{this.tipo} - {base.ToString()} - {base.MostrarExperiencia()} - Salario: {this.salario} - A cargo de: {this.personasACargo} personas - Proyectos Gestionados: {this.proyectosGestionados} - {ToString()}";
        }

        /// <summary>
        /// Devuelve una representación de cadena del objeto Gerente.
        /// </summary>
        /// <returns>Una cadena que representa el objeto Gerente.</returns>
        public override string ToString()
        {
            return "Informacion de un Gerente";
        }

        /// <summary>
        /// Comprueba si el objeto actual es igual a otro objeto Gerente.
        /// </summary>
        /// <param name="otroGerente">El objeto que se va a comparar con el objeto actual.</param>
        /// <returns>True si el objeto actual es igual al objeto especificado; de lo contrario, False.</returns>
        public override bool Equals(Object? otroGerente)
        {
            return otroGerente is Gerente && this == (Gerente)otroGerente;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}