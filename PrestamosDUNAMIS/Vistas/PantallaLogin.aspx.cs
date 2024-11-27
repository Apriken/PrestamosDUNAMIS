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
                int idPerfil = login.ObtenerIdPerfil(txt_correo.Value);
                if (idPerfil != 0)
                {
                    Session["idPerfil"] = idPerfil;
                    Response.Redirect("PaginaPrincipal.aspx");
                }
                else
                {
                    string script = "alert('Error al obtener el perfil. Inténtalo de nuevo.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
                }
            }
            else
            {
                string script = "alert('Credenciales incorrectas. Inténtalo de nuevo.');";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);
            }
        }

    }
}
