using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrestamosDUNAMIS.Vistas
{
    public partial class GestionarSaldoPrestamos : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar los préstamos y pagos solo en la primera carga de la página
                LoadPrestamos();
                LoadPagos();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores del formulario
            decimal monto = decimal.Parse(txtMonto.Text);
            DateTime fechaPago = DateTime.Parse(txtFechaPago.Text);
            int idPrestamo = int.Parse(ddlPrestamo.SelectedValue);
            decimal saldoPendiente = decimal.Parse(txtSaldoPendiente.Text);

            // Asegúrate de que si el CheckBox no está marcado, el valor sea 'False'
            bool pagoRealizado = chkPagoRealizado.Checked;

            try
            {
                // Llamar al método para guardar en la base de datos
                GuardarPago(monto, fechaPago, idPrestamo, saldoPendiente, pagoRealizado);

                // Mostrar mensaje de éxito
                lblMessage.Text = "Pago guardado correctamente.";
                lblMessage.CssClass = "text-success";

                // Recargar el GridView con los nuevos datos
                LoadPagos();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                lblMessage.Text = "Error al guardar el pago: " + ex.Message;
                lblMessage.CssClass = "text-danger";
            }
        }

        private void GuardarPago(decimal monto, DateTime fechaPago, int idPrestamo, decimal saldoPendiente, bool pagoRealizado)
        {
            // Convertir el valor booleano a entero (1 si es true, 0 si es false)
            int pagoRealizadoInt = pagoRealizado ? 1 : 0;

            string query = "INSERT INTO Pago_Prestamo (Monto_Pago, Fecha_Pago, idPrestamo, Saldo_Pendiente, Pago_Realizado) " +
                           "VALUES (@Monto_Pago, @Fecha_Pago, @idPrestamo, @Saldo_Pendiente, @Pago_Realizado)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Monto_Pago", monto);
                    cmd.Parameters.AddWithValue("@Fecha_Pago", fechaPago);
                    cmd.Parameters.AddWithValue("@idPrestamo", idPrestamo);
                    cmd.Parameters.AddWithValue("@Saldo_Pendiente", (int)saldoPendiente);  // Convertir a int si es necesario
                    cmd.Parameters.AddWithValue("@Pago_Realizado", pagoRealizadoInt);  // Usamos el valor entero para Pago_Realizado

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadPrestamos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT idPrestamo, Monto FROM Prestamo", con);
                con.Open();
                ddlPrestamo.DataSource = cmd.ExecuteReader();
                ddlPrestamo.DataTextField = "Monto";
                ddlPrestamo.DataValueField = "idPrestamo";
                ddlPrestamo.DataBind();
                ddlPrestamo.Items.Insert(0, new ListItem("--Seleccionar Préstamo--", "0"));
            }
        }

        private void LoadPagos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Modificar la consulta para incluir el campo 'idPrestamo'
                SqlDataAdapter da = new SqlDataAdapter("SELECT idPago_Prestamo, Monto_Pago, Fecha_Pago, idPrestamo, Saldo_Pendiente, Pago_Realizado FROM Pago_Prestamo", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPagos.DataSource = dt;
                gvPagos.DataBind();
            }
        }

        protected void gvPagos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvPagos.EditIndex = e.NewEditIndex;
            LoadPagos();  // Recargar datos del GridView al editar
        }

        protected void gvPagos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvPagos.EditIndex = -1;
            LoadPagos();  // Recargar datos del GridView al cancelar la edición
        }

        protected void gvPagos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idPago = Convert.ToInt32(gvPagos.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Pago_Prestamo WHERE idPago_Prestamo = @idPago", con);
                cmd.Parameters.AddWithValue("@idPago", idPago);
                con.Open();
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Registro eliminado exitosamente.";
                LoadPagos();  // Recargar datos después de eliminar
            }
        }

        protected void gvPagos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Obtener el valor del montoPago y saldoPendiente de la fila actual
                decimal montoPago = Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "Monto_Pago"));
                decimal saldoPendiente = Convert.ToDecimal(DataBinder.Eval(e.Row.DataItem, "Saldo_Pendiente"));

                // Asegurarnos de que ViewState["TotalMontoPago"] y ViewState["TotalSaldoPendiente"] existan y sean de tipo decimal
                if (ViewState["TotalMontoPago"] == null)
                {
                    ViewState["TotalMontoPago"] = 0m;  // Inicializar con 0 si es null
                }

                if (ViewState["TotalSaldoPendiente"] == null)
                {
                    ViewState["TotalSaldoPendiente"] = 0m;  // Inicializar con 0 si es null
                }

                // Verificar que los valores sean de tipo decimal antes de realizar la operación
                if (ViewState["TotalMontoPago"] is decimal)
                {
                    ViewState["TotalMontoPago"] = (decimal)ViewState["TotalMontoPago"] + montoPago;
                }

                if (ViewState["TotalSaldoPendiente"] is decimal)
                {
                    ViewState["TotalSaldoPendiente"] = (decimal)ViewState["TotalSaldoPendiente"] + saldoPendiente;
                }

                // Obtener el valor de 'Pago_Realizado' de la fila actual
                int pagoRealizado = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Pago_Realizado"));

                // Buscar el control Label en la columna 'Pago Realizado' y cambiar el texto basado en el valor
                Label lblPagoRealizado = (Label)e.Row.FindControl("lblPagoRealizado");

                if (lblPagoRealizado != null)
                {
                    if (pagoRealizado == 1)
                    {
                        lblPagoRealizado.Text = "Aprobado"; // Si es 1, mostrar "Aprobado"
                    }
                    else
                    {
                        lblPagoRealizado.Text = "Pendiente"; // Si es 0, mostrar "Pendiente"
                    }
                }
            }
        }


        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Text = string.Empty;
            txtFechaPago.Text = string.Empty;
            txtSaldoPendiente.Text = string.Empty;
            ddlPrestamo.SelectedIndex = 0;
            chkPagoRealizado.Checked = false;
            lblMessage.Text = string.Empty;
        }
    }
}
