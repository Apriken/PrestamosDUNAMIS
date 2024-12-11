using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrestamosDUNAMIS.Vistas
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["idPerfil"] == null)
                {
                    Response.Redirect("PantallaLogin.aspx");
                }
                else
                {
                    int idPerfil = (int)Session["idPerfil"];

                    // Controla la visibilidad del menú según idPerfil
                    switch (idPerfil)
                    {
                        case 2: // Administrador
                                // Todos los elementos visibles, no ocultes nada
                            break;
                        case 4: // Finanzas
                            liEvaluacionEmpleado.Visible = false;
                            liCapacidadPago.Visible = false;
                            break;
                        case 3: // Recursos Humanos
                            liGestionarSaldo.Visible = false;
                            liGestionarInteres.Visible = false;
                            break;
                        case 1: // Otros perfiles
                            liReportes.Visible = false;
                            break;
                        default:
                            // Perfil desconocido: redirigir
                            Response.Redirect("PantallaLogin.aspx");
                            break;
                    }
                }
            }
        }


    }
}