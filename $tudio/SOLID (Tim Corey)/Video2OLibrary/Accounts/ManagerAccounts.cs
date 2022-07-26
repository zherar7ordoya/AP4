using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video2OLibrary
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress =
                $"{person.FirstName.Substring(0, 1)}" +
                $"{person.LastName}@acmecorp.com",
                IsManager = true
            };

            return output;
        }
    }
}
