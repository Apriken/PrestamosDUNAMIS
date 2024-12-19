using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
                // Cargar empleados
                ddlEmpleado.DataSource = ObtenerEmpleados();
                ddlEmpleado.DataTextField = "Nombre";
                ddlEmpleado.DataValueField = "idEmpleado";
                ddlEmpleado.DataBind();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(ddlEmpleado.SelectedValue);
            decimal monto = decimal.Parse(txtMonto.Text);
            int plazos = int.Parse(txtPlazos.Text);

            if (prestamoL.RegistrarPrestamo(idEmpleado, monto, plazos, 2.0m))
            {
                Response.Write("<script>alert('Préstamo registrado con éxito');</script>");
            }
            else
            {
                Response.Write("<script>alert('Error al registrar el préstamo');</script>");
            }
        }

        private List<Empleado> ObtenerEmpleados()
        {
            // Simulación, puedes reemplazarlo con un llamado a la base de datos
            return new List<Empleado>
            {
                new Empleado { IdEmpleado = 1, Nombre = "Empleado 1" },
                new Empleado { IdEmpleado = 2, Nombre = "Empleado 2" }
            };
        }
    }
}
