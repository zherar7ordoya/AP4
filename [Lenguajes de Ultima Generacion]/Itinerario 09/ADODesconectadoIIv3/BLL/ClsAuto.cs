using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class ClsAuto
    {
        int Id { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        string Patente { get; set; }
        string Color { get; set; }

        public DataSet Listar()
        {
            DAL.Datos ODatos = new DAL.Datos();
            dynamic query = "select * From Auto";
            return ODatos.Leer(query);
        }

    }
}
