namespace OCPLibrary
{
    public class ExecutiveAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName}.{person.LastName}@corp.com";

            output.IsExecutive = true;

            return output;
        }
    }
}
