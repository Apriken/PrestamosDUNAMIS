using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrestamosDUNAMIS.Modelos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Area { get; set; }
        public string Jefe { get; set; }
        public string CorreoOrganizacional { get; set; }
        public string ClaveUsuario { get; set; }
        public int IdPlanilla { get; set; }
        public int IdPerfil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
    }
}