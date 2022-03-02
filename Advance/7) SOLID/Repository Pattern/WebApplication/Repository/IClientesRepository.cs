using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public interface IClientesRepository
    {
        IEnumerable<Clientes> ObtenerTodos();
        Clientes ObtenerPorId(int id);
        void Agregar(Clientes cliente);
        void Modificar(Clientes cliente);
        void Eliminar(int id);
        void Guardar();
    }
}
