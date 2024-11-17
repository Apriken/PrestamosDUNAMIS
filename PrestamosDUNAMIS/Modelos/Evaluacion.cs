

using System;

namespace PrestamosDUNAMIS.Modelos
{
    public class Evaluacion
    {
        public int idEvaluacion { get; set; }
        public int Rendimiento { get; set; }
        public DateTime Fecha_Evaluacion { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCriterio { get; set; }
    }
}