namespace Video2OLibrary
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress =
                $"{person.FirstName.Substring(0, 1)}" +
                $"{person.LastName}@acme.com"
            };

            //switch (person.TypeOfEmployee)
            //{
            //    case EmployeeType.Staff:
            //        break;
            //    case EmployeeType.Manager:
            //        output.IsManager = true;
            //        break;
            //    case EmployeeType.Executive:
            //        output.IsManager = true;
            //        output.IsExecutive = true;
            //        break;
            //    default:
            //        break;
            //}

            return output;
        }
    }
}
