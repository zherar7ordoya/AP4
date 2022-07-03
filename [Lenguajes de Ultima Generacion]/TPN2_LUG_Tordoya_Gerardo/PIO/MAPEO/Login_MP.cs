using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class Login_MP : ABSTRACTA.IGestor<BE.Login_BE>
    {
        readonly DAL.Conexion CONEXION;
        Hashtable HTABLA;
        public Login_MP() => CONEXION = new DAL.Conexion();

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

        public bool VerificarLogin(string usuario, string contraseña)
        {
            HTABLA = new Hashtable
            {
                { "@Usuario", usuario },
                { "@Contraseña", contraseña }
            };
            return CONEXION.LeerEscalar("Login", HTABLA);
        }
    }
}
