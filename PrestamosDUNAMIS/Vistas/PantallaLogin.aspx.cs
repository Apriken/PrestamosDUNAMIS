using PrestamosDUNAMIS.Controladores;
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
            if (login.LoginLG(txt_correo.Value, txt_contrasena.Value))
            {
                // Redirigir a la pantalla principal
                Response.Redirect("PaginaPrincipal.aspx");
            }
            else
            {
                //Muestra alerta JS
                string script = "alert('Credenciales incorrectas. Inténtalo de nuevo.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }
    }
}