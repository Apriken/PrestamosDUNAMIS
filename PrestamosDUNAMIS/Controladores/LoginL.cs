using PrestamosDUNAMIS.BaseDatos;
using PrestamosDUNAMIS.Modelos;

namespace PrestamosDUNAMIS.Controladores
{
    public class LoginL
    {
        LoginBD loginbd = new LoginBD();

        public Empleado LoginLG(string correo, string clave)
        {
            return loginbd.Login(correo, clave);
        }
    }
}
