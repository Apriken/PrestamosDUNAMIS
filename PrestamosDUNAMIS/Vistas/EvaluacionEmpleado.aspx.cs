using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Controladores;
using PrestamosDUNAMIS.Modelos;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace PrestamosDUNAMIS.Vistas
{
    public partial class EvaluacionEmpleado : System.Web.UI.Page
    {
        #region VARIABLES GLOBALES

        EvaluacionL evaluacionL = new EvaluacionL();
        Evaluacion evaluacion = new Evaluacion();

        #endregion


        #region EVENTOS

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEmpleadosEnDropDownList();
                CargarEvaluacionEnDropDownList();
                
            }
        }

        /*protected void btn_evaluar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddlEmpleado.SelectedValue) == 0)
            {
                // Manejo de error: No se ha seleccionado un empleado
                //Muestra alerta JS
                alertJS("Debe de escoger un Empleado!");
                return;
            }

            evaluacion.IdEmpleado = Convert.ToInt32(ddlEmpleado.SelectedValue);
            //evaluacion.Fecha_Evaluacion = Convert.ToDateTime(txt_fechaEvaluacion.Value);
            evaluacion.Rendimiento = Convert.ToDouble(txt_rendimiento.Value);
            evaluacion.Puntualidad = Convert.ToDouble(txt_puntualidad.Value);
            evaluacion.Productividad = Convert.ToDouble(txt_produccion.Value);
            evaluacion.Orden = Convert.ToDouble(txt_orden.Value);

            alertJS(evaluacionL.InsertaEvaluacion(evaluacion));
            //limpiar();
        }*/

        #endregion


        #region METODOS

        private void CargarEmpleadosEnDropDownList()
        {
            // Llama al método que carga los empleados
            List<Empleado> empleados = evaluacionL.cargaComboEmpleadosL();

            // Asigna la lista al DropDownList
            ddlEmpleado.DataSource = empleados;
            ddlEmpleado.DataTextField = "Nombre"; // Campo que se mostrará en el DropDownList
            ddlEmpleado.DataValueField = "IdEmpleado"; // Campo que será el valor del DropDownList
            ddlEmpleado.DataBind();

            // Opcional: Agregar un elemento por defecto
            ddlEmpleado.Items.Insert(0, new ListItem("Seleccione un empleado", "0"));
        }

        private void CargarEvaluacionEnDropDownList()
        {
            // Llama al método que carga los empleados
            List<Evaluacion> evaluacionFecha= evaluacionL.cargaComboEvaluacionFechaL();

            // Asigna la lista al DropDownList
            ddlEvaluacionFecha.DataSource = evaluacionFecha;
            ddlEvaluacionFecha.DataTextField = "Fecha"; // Campo que se mostrará en el DropDownList
            ddlEvaluacionFecha.DataValueField = "IdEmpleado"; // Campo que será el valor del DropDownList

            ddlEvaluacionFecha.DataBind();

            // Opcional: Agregar un elemento por defecto
            ddlEvaluacionFecha.Items.Insert(0, new ListItem( "aa/mm/dd")); ;
        }

        private void alertJS(string msj)
        {
            //Muestra alerta JS
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + msj + "');", true);
        }

        /*private void limpiar()
        {
            ddlEmpleado.SelectedIndex = 0;
            //txt_fechaEvaluacion.Value = string.Empty;
            txt_rendimiento.Value = string.Empty;
            txt_puntualidad.Value = string.Empty;
            txt_produccion.Value = string.Empty;
            txt_orden.Value = string.Empty;
        }*/

        #endregion

        protected void ddlEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ddlEvaluacionFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            Evaluacion evaluacionFecha = new Evaluacion();
            evaluacionFecha.IdEmpleado = 1;
            string resultado ;

            /*if (resultado == "Evaluación cargada exitosamente")
            {
                // Asignar los valores a los controles
                txt_rendimiento.Value = evaluacion.Rendimiento.ToString();
                txt_puntualidad.Value = evaluacion.Puntualidad.ToString();
                txt_produccion.Value = evaluacion.Productividad.ToString();
                txt_orden.Value = evaluacion.Orden.ToString();
            }
            else
            {
                // Si no se encuentra la evaluación, puedes mostrar un mensaje o limpiar los valores
                Response.Write("<script>alert('No se encontraron datos para este empleado.');</script>");
            }*/
        }


    }
}