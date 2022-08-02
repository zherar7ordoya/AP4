using ABS;
using BEL;

namespace DAL
{
    public class DalEmployee : IEmployee
    {
        public BelEmployee GetEmployeeDetails(int id)
        {
            // Todo: aquí hay un NEW.
            BelEmployee employee = new BelEmployee()
            {
                ID = id,
                Name = "Gerardo Tordoya",
                Department = "Development",
                Salary = 600 * 1000,
            };
            return employee;
        }
    }
}
