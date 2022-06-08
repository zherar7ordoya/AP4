using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class ClsPersona
    {

         public int Id {get; set;}
         public string Nombre { get; set; }
         public string Apellido { get; set; }
         public string Direccion { get; set; }
         public int Saldo { get; set; }

         public DataSet Listar()
         {
             DAL.Datos ODatos = new DAL.Datos();
             dynamic query = "select * From Persona";
             return ODatos.Leer(query);
         }

         public DataSet Listar2()
         {
             DAL.Datos ODatos = new DAL.Datos();

             dynamic query = "SELECT Persona_id, Persona_nombre,Persona_apellido, Persona_direccion FROM Persona; SELECT MAX(persona_id) FROM Persona";
             return ODatos.Leer(query);
         }
    }
}
