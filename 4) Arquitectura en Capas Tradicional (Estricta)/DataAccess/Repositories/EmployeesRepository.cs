using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;


namespace DataAccess.Repositories
{
    public class EmployeesRepository : MasterRepository, IEmployeeRepository
    {
        //Campos
        private readonly string select;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        //Propiedades
        //:::

        //Constructores
        public EmployeesRepository()
        {
            select = "SELECT * FROM Employee";
            insert = "INSERT INTO Employee VALUES(@idNumber, @name, @mail, @birthday)";
            update = "UPDATE Employee SET IdNumber=@idNumber, Name=@name, Mail=@mail, Birthday=@birthday WHERE IdPK=@idPk";
            delete = "DELETE FROM Employee WHERE IdPK=@idpk";
        }

        //Métodos, Comportamientos
        public int Add(Employees entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@idNumber", entidad.IdNumber),
                new SqlParameter("@name", entidad.Name),
                new SqlParameter("@mail", entidad.Mail),
                new SqlParameter("@birthday", entidad.Birthday)
            };
            return ExecuteNonQuery(insert);
        }

        public int Edit(Employees entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@idPk", entidad.IdPK),
                new SqlParameter("@idNumber", entidad.IdNumber),
                new SqlParameter("@name", entidad.Name),
                new SqlParameter("@mail", entidad.Mail),
                new SqlParameter("@birthday", entidad.Birthday)
            };
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Employees> GetAll()
        {
            var tabla = ExecuteReader(select);
            var lista = new List<Employees>();

            foreach (DataRow item in tabla.Rows)
            {
                lista.Add(new Employees
                {
                    IdPK = Convert.ToInt32(item[0]),
                    IdNumber = item[1].ToString(),
                    Name = item[2].ToString(),
                    Mail = item[3].ToString(),
                    Birthday = Convert.ToDateTime(item[4])
                });
            }
            return lista;
        }


        public int Remove(int idpk)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@idPk", idpk)
            };
            return ExecuteNonQuery(delete);
        }


        public IEnumerable<Employees> GetBySalary()
        {
            throw new NotImplementedException();
        }

    }
}
