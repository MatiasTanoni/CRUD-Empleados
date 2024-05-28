using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Representa una empresa con una lista de empleados.
    /// </summary>
    public class Empresa
    {
        // Atributos
        private List<Empleado> listaDeEmpleados;

        /// <summary>
        /// Obtiene o establece la lista de empleados en la empresa.
        /// </summary>
        public List<Empleado> ListaDeEmpleados
        {
            get { return listaDeEmpleados; }
            set { listaDeEmpleados = value; }
        }

        /// <summary>
        /// Agrega un empleado a la empresa.
        /// </summary>
        /// <param name="empresa">La empresa.</param>
        /// <param name="empleado">El empleado a agregar.</param>
        /// <returns>True si el empleado se agrega correctamente, de lo contrario false.</returns>
        public static bool operator +(Empresa empresa, Empleado empleado)
        {
            empresa.listaDeEmpleados.Add(empleado);
            return true;
        }

        /// <summary>
        /// Quita un empleado de la empresa.
        /// </summary>
        /// <param name="empresa">La empresa.</param>
        /// <param name="empleado">El empleado a quitar.</param>
        /// <returns>True si el empleado se quita correctamente, de lo contrario false.</returns>
        public static bool operator -(Empresa empresa, Empleado empleado)
        {
            empresa.listaDeEmpleados.Remove(empleado);
            return true;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Empresa"/>.
        /// </summary>
        public Empresa()
        {
            this.listaDeEmpleados = new List<Empleado>();
        }
    }


}
