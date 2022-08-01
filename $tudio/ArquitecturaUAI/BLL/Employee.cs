namespace BLL
{
    public class Employee
    {
        ABS.IEmployee AbsEmployee;

        public Employee(ABS.IEmployee employee)
        {
            AbsEmployee = employee;
        }

        public BEL.Employee GetEmployeeDetails(int id)
        {
            return AbsEmployee.GetEmployeeDetails(id);
        }
    }
}
