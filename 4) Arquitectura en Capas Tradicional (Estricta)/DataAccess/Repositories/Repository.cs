using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    /// <summary>
    /// 
    /// Requisitos:
    ///     - Tener la cadena de conexión (capa presentación)
    ///     - Agregar la referencia a System.Configuration
    /// 
    /// </summary>

    // Será abstracta: esta clase no puede ser instanciada, es decir, no se
    // puede envolver en objetos, pero sí se puede heredar, y las clases hijas
    // serán las encargadas de agregar la funcionalidad a los métodos
    // abstractos si es que lo tuviesen. 
    // Las clases abstractas se parecen a las interfaces, sin embargo, las
    // interfaces son 100% abstractas mientras que las clases abstractas pueden
    // tener funcionalidades ya definidas. Es decir, una clase abstracta es un
    // híbrido entre una interface y una clase concreta.
    public abstract class Repository
    {
        // Es privada: solo puede ser usada por ésta clase.
        // Es solo-lectura: solo se permite asignar el valor mediante la
        //                  declaración o el constructor.
        // "private" y "readonly" son formas de encapsulación.
        private readonly string cadenaDeConexion;

        public Repository()
        {
            cadenaDeConexion = ConfigurationManager
                .ConnectionStrings["PixarInc"]
                .ToString();
        }

        //Este método es protegido a fin de que sea usado solo por ésta clase y
        //las que deriven de ésta.
        protected SqlConnection AbrirConexion()
        {
            return new SqlConnection(cadenaDeConexion);
        }
    }
}
