namespace DAL
{
    public class Factory
    {
        public static ABS.IEmployee GetDAL_EmployeeObject()
        {
            return new Employee();
        }
    }
}
