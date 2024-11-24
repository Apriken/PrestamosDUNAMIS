using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Modelos;
using System.Collections.Generic;

namespace PrestamosDUNAMIS.Controladores
{
    public class EvaluacionL
    {
        EvaluacionBD EvaluacionBD = new EvaluacionBD();

        /*public string InsertaEvaluacion(Evaluacion input)
        {
            return EvaluacionBD.InsertaEvaluacion(input);
        }*/

        public List<Empleado> cargaComboEmpleadosL()
        {
            return EvaluacionBD.cargaComboEmpleados();
        }

        public List<Evaluacion> cargaComboEvaluacionFechaL()
        {
            return EvaluacionBD.cargaComboEvaluacionFecha();
        }
    }
}