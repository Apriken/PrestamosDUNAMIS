using System.Configuration;
using System.Data.SqlClient;
using System;

namespace PrestamosDUNAMIS.BaseDatos
{
    public class LoginBD
    {
        public bool Login(string correo, string clave)
        {
            // Consulta SQL para leer datos
            string query = "SELECT 1 FROM dbo.Empleado WHERE Correo_Organizacional = @Correo AND Clave_Usuario = @Clave";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Clave", clave);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
