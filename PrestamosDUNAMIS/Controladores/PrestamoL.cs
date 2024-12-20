using System.Collections.Generic;
using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Modelos;

namespace PrestamosDUNAMIS.Controladores
{
    public class PrestamoL
    {
        PrestamoBD prestamoBD = new PrestamoBD();

        public bool RegistrarPrestamo(int idEmpleado, decimal monto, int plazos, decimal interes)
        {
            return prestamoBD.RegistrarPrestamo(idEmpleado, monto, plazos, interes);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return prestamoBD.ObtenerEmpleados();
        }
    }
}
