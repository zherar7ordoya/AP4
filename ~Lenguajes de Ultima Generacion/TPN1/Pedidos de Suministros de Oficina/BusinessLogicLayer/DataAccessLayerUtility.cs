using System.Configuration;

namespace BusinessLogicLayer
{
    public static class DataAccessLayerUtility
    {
        public static string ObtenerConexionSQL(string nombre)
        {
            // Asumir fallo.
            string respuesta = null;

            // Buscar el nombre en la sección connectionStrings (App.config).
            ConnectionStringSettings configuracion = ConfigurationManager.ConnectionStrings[nombre];

            // Si se pudo encontrar, regresar la cadena de conexión.
            if (configuracion != null) respuesta = configuracion.ConnectionString;

            // Retorno.
            return respuesta;
        }
    }
    // TODO: 302
    //TODO: connectionStrings (App.config)
}
