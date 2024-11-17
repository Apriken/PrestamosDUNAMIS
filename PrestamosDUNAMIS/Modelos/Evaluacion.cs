

using System;

namespace PrestamosDUNAMIS.Modelos
{
    public class Evaluacion
    {
        public double Rendimiento { get; set; }
        public DateTime Fecha_Evaluacion { get; set; }
        public int IdEmpleado { get; set; }
        public double Puntualidad { get; set; }
        public double Productividad { get; set; }
        public double Orden { get; set; }
    }
}