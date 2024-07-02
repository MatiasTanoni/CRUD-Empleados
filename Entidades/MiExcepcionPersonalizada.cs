
namespace Entidades
{
    public class MiExcepcionPersonalizada : Exception
    {
        // Constructor que toma un mensaje personalizado
        public MiExcepcionPersonalizada(string mensaje) : base(mensaje)
        {

        }
    }
}
