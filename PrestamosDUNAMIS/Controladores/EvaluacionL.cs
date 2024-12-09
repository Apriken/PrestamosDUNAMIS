using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Modelos;
using System;
using System.Collections.Generic;
using System.Web;

namespace PrestamosDUNAMIS.Controladores
{
    public class EvaluacionL
    {
        EvaluacionBD EvaluacionBD = new EvaluacionBD();

        /*public string InsertaEvaluacion(Evaluacion input)
        {
            return EvaluacionBD.InsertaEvaluacion(input);
        }*/

        public List<Empleado> cargaComboEmpleadosL(int idPerfil)
        {
            if (idPerfil == 1)
            {
                return EvaluacionBD.cargaComboEmpleados(idPerfil, ObtenerIdEmpleado());
            }
            else
            {
                return EvaluacionBD.cargaComboEmpleados(idPerfil, null);//Trae todos los empleados
            }
        }

        public List<DateTime> cargaComboEvaluacionFechaL(int id)
        {
            return EvaluacionBD.cargaComboEvaluacionFecha(id);
        }

        public Evaluacion cargarEvaluacionL(string fecha, int Id)
        {
            return EvaluacionBD.CargarEvaluacion(fecha, Id);
        }



        private int ObtenerIdEmpleado()
        {
            if (HttpContext.Current.Session["idEmpleado"] != null)
            {
                return (int)HttpContext.Current.Session["idEmpleado"];
            }
            else
            {
                throw new Exception("La sesión no contiene 'idEmpleado'.");
            }
        }
    }
}