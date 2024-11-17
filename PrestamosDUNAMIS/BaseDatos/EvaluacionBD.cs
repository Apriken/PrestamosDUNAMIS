using PrestamosDUNAMIS.Modelos;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace PrestamosDUNAMIS.BaseDatos
{
    public class EvaluacionBD
    {
        public string InsertaEvaluacion(Evaluacion input)
        {
            // Consulta SQL para insertar datos
            string query = "INSERT INTO Evaluacion (idEvaluacion, Rendimiento, Fecha_Evaluacion, idEmpleado, idCriterio) " +
                           "VALUES (@idEvaluacion, @Rendimiento, @Fecha_Evaluacion, @idEmpleado, @idCriterio)";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@idEvaluacion", input.idEvaluacion);
                command.Parameters.AddWithValue("@Rendimiento", input.Rendimiento);
                command.Parameters.AddWithValue("@Fecha_Evaluacion", input.Fecha_Evaluacion);
                command.Parameters.AddWithValue("@idEmpleado", input.IdEmpleado);
                command.Parameters.AddWithValue("@idCriterio", input.IdCriterio);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    return "Evaluacion agregada exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}