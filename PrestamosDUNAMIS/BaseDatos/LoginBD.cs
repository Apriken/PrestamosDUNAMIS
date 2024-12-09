using System.Configuration;
using System.Data.SqlClient;
using System;
using PrestamosDUNAMIS.Modelos;

namespace PrestamosDUNAMIS.BaseDatos
{
    public class LoginBD
    {
        public Empleado Login(string correo, string clave)
        {
            Empleado empleado = new Empleado();

            string query = "SELECT idEmpleado, idPerfil FROM dbo.Empleado WHERE Correo_Organizacional = @Correo AND Clave_Usuario = @Clave";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Clave", clave);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) // Ejecutar el lector
                    {
                        if (reader.Read()) // Si hay resultados
                        {
                            empleado.IdEmpleado = reader.GetInt32(reader.GetOrdinal("idEmpleado"));
                            empleado.IdPerfil = reader.GetInt32(reader.GetOrdinal("idPerfil"));
                        }

                        return empleado;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }

    }
}