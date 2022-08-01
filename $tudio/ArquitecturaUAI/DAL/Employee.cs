namespace DAL
{
    public class Employee : ABS.IEmployee
    {
        public BEL.Employee GetEmployeeDetails(int id)
        {
            BEL.Employee employee = new BEL.Employee()
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
