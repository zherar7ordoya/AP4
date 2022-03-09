using System.Data.SqlClient;

namespace CapaDatos.Repositorios
{
    public abstract class Repositorio
    {
        private readonly string _repositorioConnectionString;
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_repositorioConnectionString);
        }
    }
}
