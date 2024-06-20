using Microsoft.Data.SqlClient;

namespace ADO
{
    public static class AccesoDatos
    {
        // Modificar la cadena de conexión para desactivar SSL
        private static string cadenaconexion = "Data Source=DESKTOP-TMUE59B\\SQLEXPRESS;Initial Catalog=Parcial;Integrated Security=True;Encrypt=False";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaconexion);
        }
    }
}

