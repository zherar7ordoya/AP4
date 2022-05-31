using System;

namespace BLLInsumosOficina
{
    public class BLLEmpleado
    {
        int _idEmpleado;
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        string _usuario;
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
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
            DALEmpleado empleado = new DALEmpleado();
            int id;
            id = empleado.LogIn(Usuario, Contraseña);
            if (id > 0)
            {
                IdEmpleado = id;
                _logueado = true;
                return true;
            }
            else
            {
                _logueado = false;
                return false;
            }
        }
    }
}
