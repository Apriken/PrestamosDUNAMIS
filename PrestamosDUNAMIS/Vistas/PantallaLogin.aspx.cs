using PrestamosDUNAMIS.Controladores;
using PrestamosDUNAMIS.Modelos;
using System;

namespace PrestamosDUNAMIS.Vistas
{
    public partial class PantallaLogin : System.Web.UI.Page
    {
        LoginL login = new LoginL();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            Empleado empleado = login.LoginLG(txt_correo.Value, txt_contrasena.Value);

            if (empleado != null)
            {
                Session["idEmpleado"] = empleado.IdEmpleado;
                Session["idPerfil"] = empleado.IdPerfil;
                Response.Redirect("PaginaPrincipal.aspx");
            }
            else
            {
                string script = "alert('Credenciales incorrectas. Inténtalo de nuevo.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

    }
}
