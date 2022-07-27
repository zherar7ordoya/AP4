namespace Video3LLibrary
{
    public class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; } = null;
        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee manager)
        {
            // Need other tasks here.
            // Otherwise,it's a property set (not a method).
            Manager = manager;
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }
    }
}
