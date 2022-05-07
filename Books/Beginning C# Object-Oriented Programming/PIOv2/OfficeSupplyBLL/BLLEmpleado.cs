using System;

namespace OfficeSupplyBLL
{
    public class BLLEmpleado
    {
        int _employeeID;

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        string _loginName;

        public string Usuario
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        string _password;

        public string Contraseña
        {
            get { return _password; }
            set { _password = value; }
        }
        Boolean _loggedIn = false;

        public Boolean LoggedIn
        {
            get { return _loggedIn; }
        }

        public Boolean Login()
        {
            DALEmpleado dbEmp = new DALEmpleado();
            int empId;
            empId = dbEmp.LogIn(Usuario, Contraseña);
            if (empId > 0)
            {
                EmployeeID = empId;
                _loggedIn = true;
                return true;
            }
            else
            {
                _loggedIn = false;
                return false;
            }

        }
    }
}
