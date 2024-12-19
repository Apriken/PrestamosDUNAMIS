using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace PrestamosDUNAMIS.BaseDatos
{
    public class PrestamoBD
    {
        public bool RegistrarPrestamo(int idEmpleado, decimal monto, int plazos, decimal interes)
        {
            string query = "INSERT INTO Prestamo (FK_idEmpleado, Monto, Fecha_Solicitud, Plazos, Interes, Estado) VALUES (@Empleado, @Monto, GETDATE(), @Plazos, @Interes, 'Pendiente')";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Empleado", idEmpleado);
                command.Parameters.AddWithValue("@Monto", monto);
                command.Parameters.AddWithValue("@Plazos", plazos);
                command.Parameters.AddWithValue("@Interes", interes);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }

}
