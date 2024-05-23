using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        //Atributos
        public List<Empleado> listaDeEmpleados;

        //Propiedad
        public List<Empleado> ListaDeEmpleados 
        { 
            get { return listaDeEmpleados; } 
            set { listaDeEmpleados = value; }
        }

        public static bool operator + (Empresa empresa, Empleado empleado)
        {
            empresa.listaDeEmpleados.Add(empleado);
            return true;
        }

        public static bool operator - (Empresa empresa, Empleado empleado)
        {
            empresa.listaDeEmpleados.Remove(empleado);
            return true;
        }
        //Constructor
        public Empresa()
        {
            this.listaDeEmpleados = new List<Empleado>();
        }
    }
}
