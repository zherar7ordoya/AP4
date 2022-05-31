using System.Data;

namespace BLLInsumosOficina
{
    public class BLLCatalogo
    {
        public DataSet ObtenerInfoProducto()
        {
            //perform any business logic befor passing to client.
            // None needed at this time.
            DALCatalogo prodCatalog = new DALCatalogo();
            return prodCatalog.GetProductInfo();
        }
    }
}