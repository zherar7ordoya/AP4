using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login_BL : ABSTRACTA.IGestor<BE.Login_BE>
    {
        readonly MPP.Login_MP LOGIN;
        public Login_BL() => LOGIN = new MPP.Login_MP();

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
            string contraseña = SEGURIDAD.Criptografia.Desencriptar(encriptado);
            return LOGIN.VerificarLogin(usuario, contraseña);
        }
    }
}
