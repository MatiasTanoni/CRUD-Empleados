using Microsoft.Data.SqlClient;

namespace ADO
{
    public static class AccesoDatos
    {
        // Modificar la cadena de conexión para desactivar SSL
        private static string cadenaconexion = "Data Source=DESKTOP-TMUE59B\\SQLEXPRESS;Initial Catalog=Parcial;Integrated Security=True;Encrypt=False";

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                return new SqlConnection(cadenaconexion);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error al intentar obtener la conexión: {ex.Message}");
                // Considera lanzar la excepción o tomar otra acción según el contexto
                throw; // Lanza la excepción para manejarla en un nivel superior
            }
        }
    }
}