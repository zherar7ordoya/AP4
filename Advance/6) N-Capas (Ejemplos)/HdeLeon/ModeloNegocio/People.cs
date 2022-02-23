using System.Collections.Generic;
using System.Linq;

namespace ModeloNegocio
{
    public class People
    {
        public static List<Datos.People> Get()
        {
            using (Datos.HdeLeonEntities db = new Datos.HdeLeonEntities())
            {
                return db.People.ToList();
            }
        }
    }
}
