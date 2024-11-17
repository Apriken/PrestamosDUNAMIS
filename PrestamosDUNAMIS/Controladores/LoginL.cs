using PrestamosDUNAMIS.BaseDatos;

namespace PrestamosDUNAMIS.Controladores
{
    public class LoginL
    {
        LoginBD loginbd = new LoginBD();

        public bool LoginLG(string correo, string clave)
        {
            return loginbd.Login(correo, clave);
        }
    }
}