namespace Video2OLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress =
                $"{person.FirstName}." +
                $"{person.LastName}@acmecorp.com",
                IsManager = true,
                IsExecutive = true
            };

            return output;
        }
    }
}
