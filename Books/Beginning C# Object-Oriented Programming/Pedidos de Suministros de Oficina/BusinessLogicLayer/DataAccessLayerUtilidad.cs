using System.Configuration;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Implementa la recuperación de la cadena de conexión de la base de datos
    /// del archivo App.config. Las otras clases llamarán a ObtenerConexionSQL
    /// para recuperar la cadena de conexión.
    /// </summary>
    public static class DataAccessLayerUtilidad
    {
        public static string ObtenerConexionSQL(string nombre)
        {
            // Asumir fallo.
            string respuesta = null;

            // Buscar el nombre en la sección connectionStrings (App.config).
            ConnectionStringSettings configuracion = 
                ConfigurationManager.ConnectionStrings[nombre];

            // Si se pudo encontrar, regresar la cadena de conexión.
            if (configuracion != null) respuesta = 
                    configuracion.ConnectionString;

            // Retorno.
            return respuesta;
        }
    }
}
