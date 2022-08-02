using ABS;

namespace DAL
{
    public class DalFactory
    {
        public static IEmployee GetDAL_EmployeeObject()
        {
            return new DalEmployee();
        }
    }
}
