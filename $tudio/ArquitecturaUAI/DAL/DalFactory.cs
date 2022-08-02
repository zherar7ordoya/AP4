using ABS;

namespace DAL
{
    public class DalFactory
    {
        public static IEmployee GetDalEmployeeObject()
        {
            return new DalEmployee();
        }
    }
}
