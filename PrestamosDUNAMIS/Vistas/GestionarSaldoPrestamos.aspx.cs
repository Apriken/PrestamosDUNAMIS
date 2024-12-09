using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
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
                LoadPrestamos();
                LoadPagos();
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pago_Prestamo", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPagos.DataSource = dt;
                gvPagos.DataBind();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pago_Prestamo (Monto_Pago, Fecha_Pago, idPrestamo, Saldo_Pendiente, Pago_Realizado) VALUES (@Monto_Pago, @Fecha_Pago, @idPrestamo, @Saldo_Pendiente, @Pago_Realizado)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Monto_Pago", txtMonto.Text);
                cmd.Parameters.AddWithValue("@Fecha_Pago", txtFechaPago.Text);
                cmd.Parameters.AddWithValue("@idPrestamo", ddlPrestamo.SelectedValue);
                cmd.Parameters.AddWithValue("@Saldo_Pendiente", txtSaldoPendiente.Text);
                cmd.Parameters.AddWithValue("@Pago_Realizado", chkPagoRealizado.Checked ? 1 : 0);

                con.Open();
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Registro guardado exitosamente.";
                LoadPagos();
            }
        }
        protected void gvPagos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvPagos.EditIndex = e.NewEditIndex;
            LoadPagos();
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
                LoadPagos();
            }
        }

        protected void gvPagos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // Restablece el índice de la fila editada para salir del modo de edición
            gvPagos.EditIndex = -1;

            // Vuelve a cargar los datos del GridView (seguramente tienes un método para cargar los datos)
            LoadPagos();
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
