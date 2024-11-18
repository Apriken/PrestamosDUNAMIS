using PrestamosDUNAMIS.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace PrestamosDUNAMIS.BaseDatos
{
    public class EvaluacionBD
    {
        public List<Empleado> cargaComboEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            // Consulta SQL para leer datos
            string query = "SELECT idEmpleado, Nombre FROM dbo.Empleado";


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(reader["idEmpleado"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                            };
                            listaEmpleados.Add(empleado);
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }

                return listaEmpleados;
            }
        }

        public string InsertaEvaluacion(Evaluacion input)
        {
            // Consulta SQL para insertar datos
            string query = "INSERT INTO Evaluacion (Rendimiento, Fecha_Evaluacion, idEmpleado, Puntualidad, Productividad, Orden) " +
                           "VALUES (@Rendimiento, @Fecha_Evaluacion, @idEmpleado, @Puntualidad, @Productividad, @Orden)";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@Rendimiento", input.Rendimiento);
                command.Parameters.AddWithValue("@Fecha_Evaluacion", input.Fecha_Evaluacion);
                command.Parameters.AddWithValue("@idEmpleado", input.IdEmpleado);
                command.Parameters.AddWithValue("@Puntualidad", input.Puntualidad);
                command.Parameters.AddWithValue("@Productividad", input.Productividad);
                command.Parameters.AddWithValue("@Orden", input.Orden);

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
