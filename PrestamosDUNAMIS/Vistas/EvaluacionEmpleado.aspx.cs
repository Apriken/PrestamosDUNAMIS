using PrestamosDUNAMIS.Controladores;
using PrestamosDUNAMIS.Modelos;
using System;

namespace PrestamosDUNAMIS.Vistas
{
    public partial class EvaluacionEmpleado : System.Web.UI.Page
    {
        EvaluacionL EvaluacionL = new EvaluacionL();

        protected void Page_Load(object sender, EventArgs e)
        {
            Evaluacion evaluacion = new Evaluacion();

            // Datos que deseas insertar
            evaluacion.idEvaluacion = 1; // Asegúrate de que este ID no exista ya en la tabla
            evaluacion.Rendimiento = 85; // Ejemplo de rendimiento
            evaluacion.Fecha_Evaluacion = DateTime.Now; // Fecha de evaluación
            evaluacion.IdEmpleado = 123; // ID del empleado (debe existir en la tabla Empleado)
            evaluacion.IdCriterio = 456; // ID del criterio (debe existir en la tabla Criterio)

            string msj = EvaluacionL.InsertaEvaluacion(evaluacion);
        }
    }
}