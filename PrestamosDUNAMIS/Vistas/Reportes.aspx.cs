using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


namespace PrestamosDUNAMIS.Vistas
{
    public partial class Reportes : System.Web.UI.Page
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string reportType = Request.Form["hfReportType"];
                if (!string.IsNullOrEmpty(reportType))
                {
                    LoadReport(reportType);
                }
            }
        }
        private void LoadReport(string reportType)
        {
            string query = string.Empty;

            switch (reportType)
            {
                case "aprobados":
                    query = @"SELECT p.idPrestamo, e.Nombre, p.Monto, p.Fecha_Solicitud AS FechaAprobacion 
                              FROM Prestamo p 
                              INNER JOIN Empleado e ON p.FK_idEmpleado = e.idEmpleado 
                              WHERE p.Estado = 'Aprobado';";
                    break;

                case "pendientes":
                    query = @"SELECT p.idPrestamo, e.Nombre, p.Monto, p.Estado 
                              FROM Prestamo p 
                              INNER JOIN Empleado e ON p.FK_idEmpleado = e.idEmpleado 
                              WHERE p.Estado = 'Pendiente';";
                    break;

                case "evaluados":
                    query = @"SELECT ev.idEmpleado, e.Nombre, 
                                     (ev.Rendimiento + ev.Puntualidad + ev.Productividad + ev.Orden) AS ResultadoEvaluacion, 
                                     ev.Fecha_Evaluacion 
                              FROM Evaluacion ev 
                              INNER JOIN Empleado e ON ev.idEmpleado = e.idEmpleado;";
                    break;

                case "intereses":
                    query = @"SELECT p.idPrestamo, e.Nombre, p.Interes AS InteresCalculado, p.Fecha_Solicitud AS Fecha 
                              FROM Prestamo p 
                              INNER JOIN Empleado e ON p.FK_idEmpleado = e.idEmpleado;";
                    break;

                default:
                    return;
            }

            if (!string.IsNullOrEmpty(query))
            {
                DataTable dt = ExecuteQuery(query);
                RenderTable(reportType, dt);
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., using System.Diagnostics or a logging library)
                Response.Write("<script>alert('Error al ejecutar la consulta: " + ex.Message + "');</script>");
            }

            return dt;
        }

        private void RenderTable(string tableId, DataTable data)
        {
            string tableHtml = string.Empty;

            foreach (DataRow row in data.Rows)
            {
                tableHtml += "<tr>";
                foreach (var item in row.ItemArray)
                {
                    tableHtml += $"<td>{item}</td>";
                }
                tableHtml += "</tr>";
            }

            ClientScript.RegisterStartupScript(GetType(), "RenderTable", $@"
                document.querySelectorAll('.table-container').forEach(function(table) {{
                    table.classList.remove('active');
                }});
                document.getElementById('{tableId}').classList.add('active');
                document.getElementById('table{char.ToUpper(tableId[0]) + tableId.Substring(1)}').innerHTML = `{tableHtml}`;
            ", true);
        }
    }
}