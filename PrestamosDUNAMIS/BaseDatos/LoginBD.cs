using System.Configuration;
using System.Data.SqlClient;
using System;

namespace PrestamosDUNAMIS.BaseDatos
{
    public class LoginBD
    {
        public bool Login(string correo, string clave)
        {
            string query = "SELECT 1 FROM dbo.Empleado WHERE Correo_Organizacional = @Correo AND Clave_Usuario = @Clave";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Clave", clave);

                try
                {
                    connection.Open();
                    return command.ExecuteScalar() != null;
                }
                catch
                {
                    return false;
                }
            }
        }

        public int ObtenerIdPerfilBD(string correo)
        {
            string query = "SELECT idPerfil FROM dbo.Empleado WHERE Correo_Organizacional = @Correo";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", correo);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
                catch
                {
                    return 0;
                }
            }
        }

    }
}