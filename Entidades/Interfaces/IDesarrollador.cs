using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    internal interface IDesarrollador
    {
        public interface IDesarrollador
        {
            TipoDeEmpleados Tipo { get; set; }
            string LenguajeDeProgramacion { get; set; }
            int ProyectosFinalizados { get; set; }

            string MostrarExperiencia();
        }
    }
}
