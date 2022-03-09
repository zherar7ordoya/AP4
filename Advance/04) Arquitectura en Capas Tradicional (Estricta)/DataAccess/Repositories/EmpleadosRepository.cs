using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;


namespace DataAccess.Repositories
{
    public class EmpleadosRepository : MasterRepository, IEmpleadosRepository
    {
        //Campos
        private readonly string select;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        //Propiedades
        //:::

        //Constructores
        public EmpleadosRepository()
        {
            insert = "INSERT INTO Empleados VALUES(@legajo, @nombre, @email, @nacimiento)";
            delete = "DELETE FROM Empleados WHERE id=@id";
            update = "UPDATE Empleados SET Legajo=@legajo, Nombre=@nombre, Email=@email, Nacimiento=@nacimiento WHERE id=@id";
            select = "SELECT * FROM Empleados";
        }

        //Métodos, Comportamientos
        public int Agregar(Empleados entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@legajo", entidad.Legajo),
                new SqlParameter("@nombre", entidad.Nombre),
                new SqlParameter("@email", entidad.Email),
                new SqlParameter("@nacimiento", entidad.Nacimiento)
            };
            return ExecuteNonQuery(insert);
        }

        public int Eliminar(int id)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@id", id)
            };
            return ExecuteNonQuery(delete);
        }

        public int Modificar(Empleados entidad)
        {
            parametros = new List<SqlParameter>
            {
                new SqlParameter("@id", entidad.Id),
                new SqlParameter("@legajo", entidad.Legajo),
                new SqlParameter("@nombre", entidad.Nombre),
                new SqlParameter("@email", entidad.Email),
                new SqlParameter("@nacimiento", entidad.Nacimiento)
            };
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Empleados> Seleccionar()
        {
            var tabla = ExecuteReader(select);
            var lista = new List<Empleados>();

            foreach (DataRow item in tabla.Rows)
            {
                lista.Add(new Empleados
                {
                    Id = Convert.ToInt32(item[0]),
                    Legajo = item[1].ToString(),
                    Nombre = item[2].ToString(),
                    Email = item[3].ToString(),
                    Nacimiento = Convert.ToDateTime(item[4])
                });
            }
            return lista;
        }

        //---

        public IEnumerable<Empleados> SeleccionarPorSueldo()
        {
            throw new NotImplementedException();
        }

        //---
    }
}
