using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using PrestamosDUNAMIS.Modelos;

namespace PrestamosDUNAMIS.BaseDatos
{
    public class PrestamoBD
    {
        public bool RegistrarPrestamo(int idEmpleado, decimal monto, int plazos, decimal interes)
        {

            string query = "INSERT INTO dbo.Prestamo (FK_idEmpleado, Monto, Fecha_Solicitud, FK_idPlazo, Interes, Estado) " +
                           "VALUES (@Empleado, @Monto, GETDATE(), @Plazo, @Interes, 'Pendiente')";

            string query = "INSERT INTO Prestamo (FK_idEmpleado, Monto, Fecha_Solicitud, Plazo, Interes, Estado) VALUES (@Empleado, @Monto, GETDATE(), @Plazo, @Interes, 'Pendiente')";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Empleado", idEmpleado);
                command.Parameters.AddWithValue("@Monto", monto);
                command.Parameters.AddWithValue("@Plazo", plazos);
                command.Parameters.AddWithValue("@Interes", interes);

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar el préstamo: " + ex.Message);
                    return false;
                }
            }
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            string query = "SELECT idEmpleado, Nombre FROM dbo.Empleado";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        empleados.Add(new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(reader["idEmpleado"]),
                            Nombre = reader["Nombre"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener empleados: " + ex.Message);
                }
            }

            return empleados;
        }
    }
}
