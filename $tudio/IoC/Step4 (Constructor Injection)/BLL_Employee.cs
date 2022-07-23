namespace Step4CI
{
    // HIGH-LEVEL MODULE (CLASS)
    public class BLL_Employee
    {
        IGestor DAL_EMPLOYEE;

        public BLL_Employee(IGestor DATA_ACCESS)
        {
            DAL_EMPLOYEE = DATA_ACCESS;
        }

        public BEL_Employee GetEmployeeDetails(int id)
        {
            return DAL_EMPLOYEE.GetEmployeeDetails(id);
        }
    }
}
