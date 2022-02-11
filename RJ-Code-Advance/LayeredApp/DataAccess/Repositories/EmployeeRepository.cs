using DataAccess.Contracts;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : MasterRepository, IEmployeeRepository
    {
        //Campos
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //Propiedades
        //:::

        //Constructores
        public EmployeeRepository()
        {
            selectAll = "SELECT * FROM Employee";
            insert = "INSERT INTO Employee VALUES(@idNumber, @name, @mail, @birthday)";
            update = "UPDATE Employee SET IdNumber=@idNumber, Name=@name, Mail=@mail, Birthday=@birthday WHERE IdPK=@idPk";
            delete = "DELETE FROM Employee WHERE IdPK=@idPk";
        }

        //Métodos, Comportamientos
        public int Add(Employee entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idNumber", entity.IdNumber));
            parameters.Add(new SqlParameter("@name", entity.Name));
            parameters.Add(new SqlParameter("@mail", entity.Mail));
            parameters.Add(new SqlParameter("@birthday", entity.Birthday));
            return ExecuteNonQuery(insert);
        }

        public int Edit(Employee entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPk", entity.IdPK));
            parameters.Add(new SqlParameter("@idNumber", entity.IdNumber));
            parameters.Add(new SqlParameter("@name", entity.Name));
            parameters.Add(new SqlParameter("@mail", entity.Mail));
            parameters.Add(new SqlParameter("@birthday", entity.Birthday));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Employee> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listEmployees = new List<Employee>();

            foreach (DataRow item in tableResult.Rows)
            {
                listEmployees.Add(new Employee
                {
                    IdPK = Convert.ToInt32(item[0]),
                    IdNumber = item[1].ToString(),
                    Name = item[2].ToString(),
                    Mail = item[3].ToString(),
                    Birthday = Convert.ToDateTime(item[4])
                });
            }
            return listEmployees;
        }

        public int Remove(int IdPK)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idPk", IdPK));
            return ExecuteNonQuery(delete);
        }
    }
}
