using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Diagnostics.Metrics;
using System.Data.SqlClient;

namespace ADO
{
    public static class Datos
    {
        public static List<Empleado> ListarUsuarios()
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
                                string tipo = Convert.ToString(reader["Tipo"]);

                                if (tipo == "Desarrollador")
                                {
                                    Desarrollador desarrollador = new Desarrollador
                                    {
                                        //Id = Convert.ToInt32(reader["Id"]),
                                        Nombre = Convert.ToString(reader["Nombre"]),
                                        Edad = Convert.ToInt32(reader["Edad"]),
                                        Experiencia = Convert.ToInt32(reader["Experiencia"]),
                                        Salario = Convert.ToInt32(reader["Salario"]),
                                        LenguajeDeProgramacion = Convert.ToString(reader["LenguajeDeProgramacion"]),
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
                                        Nombre = Convert.ToString(reader["Nombre"]),
                                        Edad = Convert.ToInt32(reader["Edad"]),
                                        Experiencia = Convert.ToInt32(reader["Experiencia"]),
                                        Salario = Convert.ToInt32(reader["Salario"]),
                                        HerramientaDePrueba = Convert.ToString(reader["HerramientaDePrueba"]),
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
                                        Nombre = Convert.ToString(reader["Nombre"]),
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
        public static void AgregarEmpleado2(string nombre, int edad, int experiencia, int salario, string herramientaDePrueba, int proyectosTesteados, TipoDeEmpleados tipo)
        {
            try
            {
                // Abrir conexión
                using (SqlConnection conexionDB = AccesoDatos.ObtenerConexion())
                {
                    // Abrir la conexión a la base de datos
                    conexionDB.Open();

                    // Consulta SQL para obtener los usuarios
                    string query = "INSERT INTO Empleado (Nombre, Edad, Experiencia, Salario,HerramientaDePrueba,ProyectosTesteados, Tipo) VALUES (@Nombre, @Edad, @Experiencia, @Salario, @HerramientaDePrueba, @ProyectosTesteados, @Tipo)";

                    // Crear un comando SQL para ejecutar la consulta
                    using (SqlCommand comando = new SqlCommand(query, conexionDB))
                    {

                        // Agregar los parámetros
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.Parameters.AddWithValue("@Experiencia", experiencia);
                        comando.Parameters.AddWithValue("@Salario", salario);
                        comando.Parameters.AddWithValue("@HerramientaDePrueba", herramientaDePrueba);
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

    }
}
