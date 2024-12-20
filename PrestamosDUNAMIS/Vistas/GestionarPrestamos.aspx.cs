using System;
using System.Web.UI.WebControls;
using PrestamosDUNAMIS.Controladores;
using PrestamosDUNAMIS.Modelos;

namespace PrestamosDUNAMIS.Vistas
{
    public partial class GestionarPrestamos : System.Web.UI.Page
    {
        PrestamoL prestamoL = new PrestamoL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEmpleados();
            }
        }

        private void CargarEmpleados()
        {
            ddlEmpleado.DataSource = prestamoL.ObtenerEmpleados();
            ddlEmpleado.DataTextField = "Nombre";
            ddlEmpleado.DataValueField = "IdEmpleado";
            ddlEmpleado.DataBind();
            ddlEmpleado.Items.Insert(0, new ListItem("-- Seleccione un empleado --", "0"));
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(ddlEmpleado.SelectedValue);
            decimal monto = decimal.Parse(txtMonto.Text);
            int plazos = int.Parse(txtPlazos.Text);
            decimal interes = 0.05m; // Ejemplo de interés fijo del 5%

            if (prestamoL.RegistrarPrestamo(idEmpleado, monto, plazos, interes))
            {
                Response.Write("<script>alert('Préstamo registrado con éxito');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al registrar el préstamo');</script>");
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            ddlEmpleado.SelectedIndex = 0;
            txtMonto.Text = string.Empty;
            txtPlazos.Text = string.Empty;
        }
    }
}
