namespace OCPLibrary
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;

            string minusculas = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";

            output.EmailAddress = minusculas.ToLower();

            return output;
        }
    }
}
