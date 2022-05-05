using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Esta clase encapsulará la información de los empleados utilizada por la
    /// interfaz de usuario y pasará una solicitud de inicio de sesión a la
    /// capa de acceso a datos (DAL).
    /// </summary>
    public class BusinessLogicLayerEmpleado
    {
        int _idEmpleado;

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        string _usuarioLogin;

        public string UsuarioLogin
        {
            get { return _usuarioLogin; }
            set { _usuarioLogin = value; }
        }

        string _contraseña;

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        Boolean _logueado = false;

        public Boolean Logueado
        {
            get { return _logueado; }
        }

        public Boolean Login()
        {
            DataAccessLayerEmpleado empleadoDAL = new DataAccessLayerEmpleado();
            int id_empleado;
            id_empleado = empleadoDAL.Login(this.UsuarioLogin, this.Contraseña);
            if (id_empleado > 0)
            {
                this.IdEmpleado = id_empleado;
                this._logueado = true;
                return true;
            }
            else
            {
                this._logueado = false;
                return false;
            }

        }
    }
}
