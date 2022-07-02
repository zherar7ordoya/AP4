using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Login_BL : ABSTRACCION.IGestor<BE.Login_BE>
    {
        readonly MAPEO.Login_MP LOGIN;
        public Login_BL() => LOGIN = new MAPEO.Login_MP();

        // *---------------------------------------------=> IMPLEMENTA INTERFAZ

        public bool Eliminar(BE.Login_BE objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE.Login_BE objeto)
        {
            throw new NotImplementedException();
        }

        public BE.Login_BE ListarObjeto(BE.Login_BE objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE.Login_BE> ListarTodo()
        {
            throw new NotImplementedException();
        }

        // *----------------------------------------------------=> VERIFICACIÓN

        public bool VerificarLogin(string usuario, string encriptado)
        {
            string contraseña = SECURITY.Criptografia.Desencriptar(encriptado);
            return LOGIN.VerificarLogin(usuario, contraseña);
        }
    }
}
