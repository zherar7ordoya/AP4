using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;

using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Domain.Models
{
    public class EmployeeModel
    {
        private int idPK;
        private string idNumber;
        private string name;
        private string mail;
        private DateTime birthday;
        private int age;

        private IEmployeeRepository employeeRepository;
        public EntityState State { private get; set; }
        private List<EmployeeModel> listEmployees;

        //Propiedades / Modelo de Vista / Validar Datos
        public int IdPK { get => idPK; set => idPK = value; }

        [Required(ErrorMessage = "The field identification number is required.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Identification number must be only numbers.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Identification number must be 10 digits.")]
        public string IdNumber { get => idNumber; set => idNumber = value; }

        [Required]
        [RegularExpression("^[A-Z]+[a-zA-Z]+$", ErrorMessage = "The field must be only letters.")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Name { get => name; set => name = value; }

        [Required]
        [EmailAddress]
        public string Mail { get => mail; set => mail = value; }

        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Age { get => age; private set => age = value; }

        public EmployeeModel()
        {
            employeeRepository = new EmployeeRepository();
        }

        public string SaveChanges()
        {
            string message = null;

            try
            {
                var employeeDataModel = new Employee();

                employeeDataModel.IdPK = idPK;
                employeeDataModel.IdNumber = idNumber;
                employeeDataModel.Name = name;
                employeeDataModel.Mail = mail;
                employeeDataModel.Birthday = birthday;

                switch(State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales / cálculos.
                        employeeRepository.Add(employeeDataModel);
                        message = "Successfully added.";
                        break;

                    case EntityState.Deleted:
                        // Ejecutar reglas comerciales / cálculos.
                        employeeRepository.Remove(idPK);
                        message = "Successfully deleted.";
                        break;

                    case EntityState.Modified:
                        // Ejecutar reglas comerciales / cálculos.
                        employeeRepository.Edit(employeeDataModel);
                        message = "Successfully modified.";
                        break;
                }
            }
            catch (Exception ex)
            {
                SqlException sqlEx = ex as SqlException;

                //SQL Server 2627: registro ya existe (duplicado)
                if(sqlEx != null && sqlEx.Number == 2627)
                {
                    message = "Duplicated record.";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public List<EmployeeModel> GetAll()
        {
            var employeeDataModel = employeeRepository.GetAll();
            listEmployees = new List<EmployeeModel>();

            foreach(Employee item in employeeDataModel)
            {
                var birthDate = item.Birthday;

                listEmployees.Add(new EmployeeModel
                {
                    idPK=item.IdPK,
                    idNumber = item.IdNumber,
                    name = item.Name,
                    mail = item.Mail,
                    birthday = item.Birthday,
                    age = CalculateAge(birthDate)
                });
            }
            return listEmployees;
        }

        public IEnumerable<EmployeeModel> FindById(string filter)
        {
            return listEmployees.FindAll(e => 
            e.idNumber.Contains(filter) || e.Name.Contains(filter)
            );
        }

        private int CalculateAge(DateTime date)
        {
            DateTime dateNow = DateTime.Now;
            return dateNow.Year - date.Year;
        }
    }
}
