using System.ComponentModel.DataAnnotations;

namespace PrestamosDUNAMIS
{
    public class CapacidadPagoModel
    {
        public double SalarioBruto { get; set; }
        public double Deducciones { get; set; }
        public double SalarioNeto { get; set; }
        public double CargasSociales { get; set; }
        public double CapacidadPago { get; set; }

        public const double PorcentajeCargasSociales = 9.34;

        public void Calcular()
        {
            CargasSociales = SalarioBruto * PorcentajeCargasSociales / 100;
            SalarioNeto = SalarioBruto - CargasSociales;
            CapacidadPago = SalarioNeto - Deducciones;
        }
    }
}
