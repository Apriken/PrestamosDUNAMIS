using System;
using PrestamosDUNAMIS;
using PrestamosDUNAMIS.Modelos;

namespace PrestamosDUNAMIS
{
    public partial class CapacidadPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResultadosPanel.Visible = false;
            }
        }

        protected void CalcularCapacidadPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entradas
                double salarioBruto = string.IsNullOrEmpty(SalarioBrutoInput.Text) ? 0 : Convert.ToDouble(SalarioBrutoInput.Text);
                double deducciones = string.IsNullOrEmpty(DeduccionesInput.Text) ? 0 : Convert.ToDouble(DeduccionesInput.Text);

                // Cálculo de Cargas Sociales
                const double porcentajeCargasSociales = 9.34 / 100;
                double cargasSociales = salarioBruto * porcentajeCargasSociales;
                double salarioNeto = salarioBruto - cargasSociales;
                double capacidadPago = salarioNeto - deducciones;

                // Mostrar resultados
                CargasSocialesLabel.Text = Math.Round(cargasSociales).ToString();
                DeduccionesRebajoLabel.Text = Math.Round(deducciones).ToString();
                SalarioNetoLabel.Text = Math.Round(salarioNeto).ToString();
                CapacidadPagoLabel.Text = Math.Round(capacidadPago).ToString();
                ResultadosPanel.Visible = true;
            }
            catch (Exception ex)
            {
                // Manejar errores (opcional)
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
