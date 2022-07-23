namespace Step4CI
{
    class DAL_Factory
    {
        public static IGestor GetDAL_EmployeeObject()
        {
            return new DAL_Employee();
        }
    }
}
