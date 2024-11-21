using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Modelos;

public class PrestamoL
{
    private string connectionString = ConfigurationManager.ConnectionStrings["PrestamosDUNAMISDB"].ConnectionString;

    public bool RegistrarPrestamo(Prestamo prestamo)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Prestamos (IdEmpleado, Monto, FechaSolicitud, Plazos, Interes, Estado) " +
                           "VALUES (@IdEmpleado, @Monto, GETDATE(), @Plazos, @Interes, 'Pendiente')";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdEmpleado", prestamo.IdEmpleado);
            command.Parameters.AddWithValue("@Monto", prestamo.Monto);
            command.Parameters.AddWithValue("@Plazos", prestamo.Plazos);
            command.Parameters.AddWithValue("@Interes", prestamo.Interes);

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }
    }

    public List<Prestamo> ListarPrestamos()
    {
        List<Prestamo> prestamos = new List<Prestamo>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Prestamos";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                prestamos.Add(new Prestamo
                {
                    IdPrestamo = Convert.ToInt32(reader["IdPrestamo"]),
                    IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                    Monto = Convert.ToDecimal(reader["Monto"]),
                    FechaSolicitud = Convert.ToDateTime(reader["FechaSolicitud"]),
                    Plazos = Convert.ToInt32(reader["Plazos"]),
                    Interes = Convert.ToDecimal(reader["Interes"]),
                    Estado = reader["Estado"].ToString()
                });
            }
        }
        return prestamos;
    }
}
