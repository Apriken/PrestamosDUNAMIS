using System;

namespace Modelos
{
	public class Prestamo
	{
		public int IdPrestamo { get; set; }
		public int IdEmpleado { get; set; }
		public decimal Monto { get; set; }
		public DateTime FechaSolicitud { get; set; }
		public int Plazos { get; set; }
		public decimal Interes { get; set; }
		public string Estado { get; set; }
	}
}