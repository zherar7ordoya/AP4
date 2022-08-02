using ABS;
using BEL;

namespace BLL
{
    public class BllEmployee
    {
        readonly IEmployee iEmployee;

        public BllEmployee(IEmployee employee)
        {
            iEmployee = employee;
        }

        public BelEmployee GetEmployeeDetails(int id)
        {
            return iEmployee.GetEmployeeDetails(id);
        }
    }
}
