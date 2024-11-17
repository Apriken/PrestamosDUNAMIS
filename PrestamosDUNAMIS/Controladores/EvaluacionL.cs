using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Modelos;

namespace PrestamosDUNAMIS.Controladores
{
    public class EvaluacionL
    {
        EvaluacionBD EvaluacionBD = new EvaluacionBD();

        public string InsertaEvaluacion(Evaluacion input)
        {
            return EvaluacionBD.InsertaEvaluacion(input);
        }
    }
}