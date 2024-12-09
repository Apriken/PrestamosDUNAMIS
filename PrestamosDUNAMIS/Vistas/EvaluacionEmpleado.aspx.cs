using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Controladores;
using PrestamosDUNAMIS.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web;
using System.Web.UI.WebControls;

namespace PrestamosDUNAMIS.Vistas
{
    public partial class EvaluacionEmpleado : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES

        EvaluacionL evaluacionL = new EvaluacionL();

        #endregion


        #region EVENTOS

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEmpleadosEnDropDownList();
                cargarFechasEvaluacionEnDropDownList(Convert.ToInt32(ddlEmpleado.SelectedValue));
            }
        }

        protected void ddlEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarFechasEvaluacionEnDropDownList(Convert.ToInt32(ddlEmpleado.SelectedValue));

            if (!(ddlEvaluacionFecha.SelectedValue == null || String.IsNullOrEmpty(ddlEvaluacionFecha.SelectedValue)))
            {
                cargaInfo(evaluacionL.cargarEvaluacionL(ddlEvaluacionFecha.SelectedValue, Convert.ToInt32(ddlEmpleado.SelectedValue)));
            }
        }

        protected void ddlEvaluacionFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaInfo(evaluacionL.cargarEvaluacionL(ddlEvaluacionFecha.SelectedValue, Convert.ToInt32(ddlEmpleado.SelectedValue)));
        }

        #endregion


        #region METODOS

        private void CargarEmpleadosEnDropDownList()
        {
            int idPerfil = ObtenerIdPerfil();

            // Llama al método que carga los empleados
            List<Empleado> empleados = evaluacionL.cargaComboEmpleadosL(idPerfil);

            // Asigna la lista al DropDownList
            ddlEmpleado.DataSource = empleados;
            ddlEmpleado.DataTextField = "Nombre"; // Campo que se mostrará en el DropDownList
            ddlEmpleado.DataValueField = "IdEmpleado"; // Campo que será el valor del DropDownList
            ddlEmpleado.DataBind();

            if (idPerfil == 1)
            {
                ddlEmpleado.Enabled = false;      
            }
            else
            {
                ddlEmpleado.Items.Insert(0, new ListItem("Seleccione un empleado", "0"));
            }
        }

        private void cargarFechasEvaluacionEnDropDownList(int id)
        {
            List<DateTime> listaFechas = evaluacionL.cargaComboEvaluacionFechaL(id);

            // Lista para mostrar la fecha bonita
            List<string> listaFechasFormateadas = new List<string>();

            // Formatear las fechas
            foreach (DateTime fecha in listaFechas)
            {
                // Formatear la fecha usando la cultura española
                listaFechasFormateadas.Add((fecha.ToString("D", new CultureInfo("es-ES"))));
            }

            // Configurar el DropDownList
            ddlEvaluacionFecha.DataSource = listaFechasFormateadas;
            ddlEvaluacionFecha.DataBind();
        }

        private void cargaInfo(Evaluacion input)
        {
            if (!(input == null))
            {
                txt_rendimiento.Value = input.Rendimiento.ToString();
                txt_puntualidad.Value = input.Puntualidad.ToString();
                txt_produccion.Value = input.Productividad.ToString();
                txt_orden.Value = input.Orden.ToString();
            }
        }


        private int ObtenerIdPerfil()
        {
            if (HttpContext.Current.Session["idPerfil"] != null)
            {
                return (int)HttpContext.Current.Session["idPerfil"];
            }
            else
            {
                throw new Exception("La sesión no contiene 'idPerfil'.");
            }
        }

        #endregion

    }
}