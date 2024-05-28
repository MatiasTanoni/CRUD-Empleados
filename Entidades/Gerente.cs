using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que representa a un gerente dentro de la empresa.
    /// </summary>
    public class Gerente : Empleado
    {
        // Atributos
        private int salario;
        private int personasACargo;
        private int proyectosGestionados;

        // Propiedades
        /// <summary>
        /// Obtiene o establece el salario del gerente.
        /// </summary>
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
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

        // Constructor
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/>.
        /// </summary>
        /// <param name="nombre">El nombre del gerente.</param>
        /// <param name="edad">La edad del gerente.</param>
        /// <param name="experiencia">La experiencia del gerente.</param>
        public Gerente(string nombre, int edad, int experiencia) : base(nombre, edad, experiencia)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/> con el salario especificado.
        /// </summary>
        /// <param name="salario">El salario del gerente.</param>
        /// <param name="nombre">El nombre del gerente.</param>
        /// <param name="edad">La edad del gerente.</param>
        /// <param name="experiencia">La experiencia del gerente.</param>
        public Gerente(int salario, string nombre, int edad, int experiencia) : this(nombre, edad, experiencia)
        {
            this.salario = salario;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Gerente"/> con el salario y la cantidad de personas a cargo especificados.
        /// </summary>
        /// <param name="salario">El salario del gerente.</param>
        /// <param name="personasACargo">La cantidad de personas a cargo del gerente.</param>
        /// <param name="nombre">El nombre del gerente.</param>
        /// <param name="edad">La edad del gerente.</param>
        /// <param name="experiencia">La experiencia del gerente.</param>
        public Gerente(int salario, int personasACargo, string nombre, int edad, int experiencia) : this(salario, nombre, edad, experiencia)
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
        public Gerente(int salario, int personasACargo, int proyectosGestionados, string nombre, int edad, int experiencia) : this(salario, personasACargo, nombre, edad, experiencia)
        {
            this.proyectosGestionados = proyectosGestionados;
        }

        /// <summary>
        /// Devuelve la información del gerente.
        /// </summary>
        /// <returns>La información del gerente.</returns>
        public override string MostrarInformacion()
        {
            return $"Nombre: {this.nombre} - Edad: {this.edad} - Experiencia: {this.experiencia} - Salario: {this.salario} - A cargo de: {this.personasACargo} personas - Proyectos Gestionados: {this.proyectosGestionados}";
        }
    }

}
