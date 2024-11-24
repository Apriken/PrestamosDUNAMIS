using PrestamosDUNAMIS.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

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

        public List<Evaluacion> cargaComboEvaluacionFecha()
        {
            List<Evaluacion> listaEvaluacion = new List<Evaluacion>();

            // Consulta SQL para leer datos
            StringBuilder query = new StringBuilder();

            query.AppendLine("SELECT A.Fecha_Evaluacion");
            query.AppendLine("FROM Evaluacion A");
            query.AppendLine("INNER JOIN Empleado B ON A.idEmpleado =  B.idEmpleado");
            query.AppendLine("WHERE B.idEmpleado = 1");


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query.ToString(), connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var evaluacion = new Evaluacion
                            {
                                Fecha_Evaluacion = Convert.ToDateTime(reader["Fecha_Evaluacion"]),
                                IdEmpleado = Convert.ToInt32(reader["idEmpleado"])
                                
                            };
                            listaEvaluacion.Add(evaluacion);
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }

                return listaEvaluacion;
            }
        }

        public string CargarEvaluacion(Evaluacion input)
        {
            // Consulta SQL para insertar datos
            string query = "SELECT A.Rendimiento,A.Puntualidad,A.Productividad,A.Orden " +
                           "FROM Evaluacion A"+
                           "INNER JOIN Empleado B ON A.idEmpleado =  B.idEmpleado" +
                           "WHERE B.idEmpleado = @idEmpleado";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnx"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Agregar parámetro de idEmpleado
                command.Parameters.AddWithValue("@idEmpleado", input.IdEmpleado);

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Verifica si se encuentran datos
                        {
                            // Cargar los valores en el objeto Evaluacion
                            input.Rendimiento = Convert.ToDouble(reader["Rendimiento"].ToString());
                            input.Puntualidad = Convert.ToDouble(reader["Puntualidad"].ToString());
                            input.Productividad = Convert.ToDouble(reader["Productividad"].ToString());
                            input.Orden = Convert.ToDouble(reader["Orden"].ToString());

                            return "Evaluación cargada exitosamente";
                        }
                        else
                        {
                            return "No se encontraron datos para este empleado";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
        }

        /*public string InsertaEvaluacion(Evaluacion input)
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
        }*/
    }
}
