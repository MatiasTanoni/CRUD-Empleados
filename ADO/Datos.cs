using Microsoft.Data.SqlClient;
using Entidades;

namespace ADO
{
    public static class Datos
    {
        /// <summary>
        /// Obtiene una lista de empleados desde la base de datos.
        /// </summary>
        /// <returns>Una lista de empleados.</returns>
        public static List<Empleado> ListarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();

            try
            {
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    conexionDB.Open();
                    string query = "SELECT * FROM Empleado";

                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tipo = reader["Tipo"] as string ?? string.Empty;

                                if (tipo == "Desarrollador")
                                {
                                    Desarrollador desarrollador = new Desarrollador
                                    {
                                        Id = Convert.ToInt32(reader["id"]),
                                        Nombre = reader["Nombre"] as string ?? string.Empty,
                                        Edad = Convert.ToInt32(reader["Edad"]),
                                        Experiencia = Convert.ToInt32(reader["Experiencia"]),
                                        Salario = Convert.ToInt32(reader["Salario"]),
                                        LenguajeDeProgramacion = reader["LenguajeDeProgramacion"] as string ?? string.Empty,
                                        ProyectosFinalizados = Convert.ToInt32(reader["ProyectosFinalizados"]),

                                    };
                                    if (Enum.TryParse(reader["Tipo"].ToString(), out TipoDeEmpleados tipoDeEmpleados))
                                    {
                                        desarrollador.Tipo = tipoDeEmpleados;
                                    };
                                    lista.Add(desarrollador);
                                }
                                else if (tipo == "Tester")
                                {
                                    Tester tester = new Tester
                                    {
                                        Id = Convert.ToInt32(reader["id"]),
                                        Nombre = reader["Nombre"] as string ?? string.Empty,
                                        Edad = Convert.ToInt32(reader["Edad"]),
                                        Experiencia = Convert.ToInt32(reader["Experiencia"]),
                                        Salario = Convert.ToInt32(reader["Salario"]),
                                        HerramientaDePrueba = reader["HerramientasDePrueba"] as string ?? string.Empty,
                                        ProyectosTesteados = Convert.ToInt32(reader["ProyectosTesteados"])
                                    };
                                    if (Enum.TryParse(reader["Tipo"].ToString(), out TipoDeEmpleados tipoDeEmpleados))
                                    {
                                        tester.Tipo = tipoDeEmpleados;
                                    };
                                    lista.Add(tester);
                                }
                                else if (tipo == "Gerente")
                                {
                                    Gerente gerente = new Gerente
                                    {
                                        Id = Convert.ToInt32(reader["id"]),
                                        Nombre = reader["Nombre"] as string ?? string.Empty,
                                        Edad = Convert.ToInt32(reader["Edad"]),
                                        Experiencia = Convert.ToInt32(reader["Experiencia"]),
                                        Salario = Convert.ToInt32(reader["Salario"]),
                                        PersonasACargo = Convert.ToInt32(reader["PersonasACargo"]),
                                        ProyectosGestionados = Convert.ToInt32(reader["ProyectosGestionados"]),
                                    };
                                    if (Enum.TryParse(reader["Tipo"].ToString(), out TipoDeEmpleados tipoDeEmpleados))
                                    {
                                        gerente.Tipo = tipoDeEmpleados;
                                    };
                                    lista.Add(gerente);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Lanza una nueva excepción con un mensaje específico
                throw new Exception("Error al listar los usuarios" + e.Message);
            }

            // Devuelve la lista de usuarios
            return lista;
        }
        /// <summary>
        /// Método para agregar un nuevo empleado a la base de datos.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="clave">La clave del usuario.</param>
        public static void AgregarEmpleado(string nombre, int edad, int experiencia, int salario, string lenguajeDeProgramacion, int proyectosFinalizados, TipoDeEmpleados tipo)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para obtener los usuarios
                    string query = "INSERT INTO Empleado (Nombre, Edad, Experiencia, Salario, LenguajeDeProgramacion, ProyectosFinalizados, Tipo) VALUES (@Nombre, @Edad, @Experiencia, @Salario, @LenguajeDeProgramacion, @ProyectosFinalizados, @Tipo)";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {

                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.Parameters.AddWithValue("@Experiencia", experiencia);
                        comando.Parameters.AddWithValue("@Salario", salario);
                        comando.Parameters.AddWithValue("@LenguajeDeProgramacion", lenguajeDeProgramacion);
                        comando.Parameters.AddWithValue("@ProyectosFinalizados", proyectosFinalizados);
                        comando.Parameters.AddWithValue("@Tipo", tipo.ToString());

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {
                // Lanza una nueva excepción con un mensaje específico
                throw new Exception("Error al agregar el usuario" + e.Message);
            }
        }
        /// <summary>
        /// Método para agregar un nuevo empleado a la base de datos.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="clave">La clave del usuario.</param>
        public static void AgregarEmpleado(string nombre, int edad, int experiencia, int salario, string herramientaDePrueba, TipoDeEmpleados tipo,int proyectosTesteados)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para obtener los usuarios
                    string query = "INSERT INTO Empleado (Nombre, Edad, Experiencia, Salario,HerramientasDePrueba,Tipo,ProyectosTesteados) VALUES (@Nombre, @Edad, @Experiencia, @Salario, @HerramientasDePrueba,@Tipo, @ProyectosTesteados)";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {

                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.Parameters.AddWithValue("@Experiencia", experiencia);
                        comando.Parameters.AddWithValue("@Salario", salario);
                        comando.Parameters.AddWithValue("@HerramientasDePrueba", herramientaDePrueba);
                        comando.Parameters.AddWithValue("@ProyectosTesteados", proyectosTesteados);
                        comando.Parameters.AddWithValue("@Tipo", tipo.ToString());

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {
                // Lanza una nueva excepción con un mensaje específico
                throw new Exception("Error al agregar el usuario" + e.Message);
            }
        }
        /// <summary>
        /// Método para agregar un nuevo empleado a la base de datos.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="clave">La clave del usuario.</param>
        public static void AgregarEmpleado(string nombre, int edad, int experiencia, int salario, int personasACargo, TipoDeEmpleados tipo,int proyectosGestionados)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para obtener los usuarios
                    string query = "INSERT INTO Empleado (Nombre, Edad, Experiencia, Salario, PersonasACargo,Tipo,ProyectosGestionados) VALUES (@Nombre, @Edad, @Experiencia, @Salario, @PersonasACargo,@Tipo, @ProyectosGestionados)";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {

                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.Parameters.AddWithValue("@Experiencia", experiencia);
                        comando.Parameters.AddWithValue("@Salario", salario);
                        comando.Parameters.AddWithValue("@PersonasACargo", personasACargo);
                        comando.Parameters.AddWithValue("@ProyectosGestionados", proyectosGestionados);
                        comando.Parameters.AddWithValue("@Tipo", tipo.ToString());

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {
                // Lanza una nueva excepción con un mensaje específico
                throw new Exception("Error al agregar el usuario" + e.Message);
            }
        }
        public static void ModificarEmpleado(string nombre, int edad, int experiencia, int salario, string lenguajeDeProgramacion, int proyectosFinalizados, TipoDeEmpleados tipo,int id)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para obtener los usuarios
                    string query = "UPDATE Empleado SET Nombre = @Nombre, Edad = @Edad, Experiencia = @Experiencia, Salario = @Salario, LenguajeDeProgramacion = @LenguajeDeProgramacion, ProyectosFinalizados = @ProyectosFinalizados, Tipo = @Tipo WHERE Id = @Id";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {

                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.Parameters.AddWithValue("@Experiencia", experiencia);
                        comando.Parameters.AddWithValue("@Salario", salario);
                        comando.Parameters.AddWithValue("@LenguajeDeProgramacion", lenguajeDeProgramacion);
                        comando.Parameters.AddWithValue("@ProyectosFinalizados", proyectosFinalizados);
                        comando.Parameters.AddWithValue("@Tipo", tipo.ToString());

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {
                // Lanza una nueva excepción con un mensaje específico
                throw new Exception("Error al agregar el usuario" + e.Message);
            }
        }
        /// <summary>
        /// Modifica los datos de un empleado en la base de datos.
        /// </summary>
        public static void ModificarEmpleado(string nombre, int edad, int experiencia, int salario, string herramientaDePrueba, TipoDeEmpleados tipo, int proyectosTesteados,int id)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para actualizar los datos del empleado
                    string query = "UPDATE Empleado SET Nombre = @Nombre, Edad = @Edad, Experiencia = @Experiencia, Salario = @Salario, HerramientasDePrueba = @HerramientasDePrueba, Tipo = @Tipo, ProyectosTesteados = @ProyectosTesteados WHERE Id = @Id";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {
                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.Parameters.AddWithValue("@Experiencia", experiencia);
                        comando.Parameters.AddWithValue("@Salario", salario);
                        comando.Parameters.AddWithValue("@HerramientasDePrueba", herramientaDePrueba);
                        comando.Parameters.AddWithValue("@ProyectosTesteados", proyectosTesteados);
                        comando.Parameters.AddWithValue("@Tipo", tipo.ToString());

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                // Lanza una nueva excepción con un mensaje específico
                throw new Exception("Error al actualizar el empleado: " + e.Message);
            }
        }
        /// <summary>
        /// Modifica los datos de un empleado en la base de datos.
        /// </summary>
        public static void ModificarEmpleado(string nombre, int edad, int experiencia, int salario, int personasACargo, int proyectosGestionados, int id, TipoDeEmpleados tipo)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para actualizar los datos del empleado
                    string query = "UPDATE Empleado SET Nombre = @Nombre, Edad = @Edad, Experiencia = @Experiencia, Salario = @Salario, PersonasACargo = @PersonasACargo, Tipo = @Tipo, ProyectosGestionados = @ProyectosGestionados WHERE Id = @Id";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {
                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.Parameters.AddWithValue("@Experiencia", experiencia);
                        comando.Parameters.AddWithValue("@Salario", salario);
                        comando.Parameters.AddWithValue("@PersonasACargo", personasACargo);
                        comando.Parameters.AddWithValue("@ProyectosGestionados", proyectosGestionados);
                        comando.Parameters.AddWithValue("@Tipo", tipo.ToString());

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                // Lanza una nueva excepción con un mensaje específico
                throw new Exception("Error al actualizar el empleado: " + e.Message);
            }
        }
        /// <summary>
        /// Elimina un empleado en la base de datos.
        /// </summary>
        public static void EliminarEmpleado(int id)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para eliminar el empleado
                    string query = "DELETE FROM Empleado WHERE Id = @Id";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {
                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Id", id);

                        // Ejecutar la consulta
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al eliminar el empleado", ex);
            }
        }
    }
}
