using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Modelos;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

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

        public List<DateTime> cargaComboEvaluacionFechaL(int id)
        {
            return EvaluacionBD.cargaComboEvaluacionFecha(id);
        }

        public Evaluacion cargarEvaluacionL(string fecha, int Id)
        {
            return EvaluacionBD.CargarEvaluacion(fecha, Id);
        }
    }
}