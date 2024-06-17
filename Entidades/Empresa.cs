using System;
using System.Collections.Generic;
using System.Linq;

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
        /// Inicializa una nueva instancia de la clase <see cref="Empresa"/>.
        /// </summary>
        public Empresa()
        {
            this.listaDeEmpleados = new List<Empleado>();
        }

        /// <summary>
        /// Sobrecarga del operador de adición para agregar un empleado a la lista de empleados de la empresa.
        /// </summary>
        /// <param name="empresa">La empresa a la que se agregará el empleado.</param>
        /// <param name="empleado">El empleado que se agregará a la empresa.</param>
        /// <returns>La empresa con el empleado agregado.</returns>
        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            empresa.listaDeEmpleados.Add(empleado);
            return empresa;
        }

        /// <summary>
        /// Sobrecarga del operador de substracción para eliminar un empleado de la lista de empleados de la empresa.
        /// </summary>
        /// <param name="empresa">La empresa de la que se eliminará el empleado.</param>
        /// <param name="empleado">El empleado que se eliminará de la empresa.</param>
        /// <returns>La empresa con el empleado eliminado.</returns>
        public static Empresa operator -(Empresa empresa, Empleado empleado)
        {
            empresa.listaDeEmpleados.Remove(empleado);
            return empresa;
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad para comprobar si un empleado está en la lista de empleados de la empresa.
        /// </summary>
        /// <param name="empresa">La empresa en la que se buscará el empleado.</param>
        /// <param name="empleado">El empleado que se buscará en la lista de empleados de la empresa.</param>
        /// <returns>True si el empleado está en la lista de empleados de la empresa; de lo contrario, False.</returns>
        public static bool operator ==(Empresa empresa, Empleado empleado)
        {
            return empresa.ListaDeEmpleados.Contains(empleado);
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad para comprobar si un empleado no está en la lista de empleados de la empresa.
        /// </summary>
        /// <param name="empresa">La empresa en la que se buscará el empleado.</param>
        /// <param name="empleado">El empleado que se buscará en la lista de empleados de la empresa.</param>
        /// <returns>True si el empleado no está en la lista de empleados de la empresa; de lo contrario, False.</returns>
        public static bool operator !=(Empresa empresa, Empleado empleado)
        {
            return !(empresa == empleado);
        }

        /// <summary>
        /// Sobrescribe el método Equals para comparar si dos objetos Empresa son iguales.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>True si los objetos son iguales; de lo contrario, False.</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Empresa other = (Empresa)obj;
            return listaDeEmpleados.SequenceEqual(other.listaDeEmpleados);
        }

        /// <summary>
        /// Sobrescribe el método GetHashCode para obtener el código hash del objeto Empresa.
        /// </summary>
        /// <returns>Código hash del objeto.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(listaDeEmpleados);
        }
    }
}
