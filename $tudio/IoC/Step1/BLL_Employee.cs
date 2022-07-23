using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step1
{
    public class BLL_Employee
    {
        readonly DAL_Employee DAL_EMPLOYEE;
        public BLL_Employee()
        {
            DAL_EMPLOYEE = new DAL_Employee();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public BEL_Employee GetEmployeeDetails(int id)
        {
            return DAL_EMPLOYEE.GetEmployeeDetails(id);
        }
    }
}
