using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public DataEntityTier.NorthWindDataSet.CustomersDataTable GetCustomers()
        {
            DataAccessTier.NorthWindDataSetTableAdapters.CustomersTableAdapter
                 CustomersTableAdapter1
                = new DataAccessTier.NorthWindDataSetTableAdapters.CustomersTableAdapter();
            return CustomersTableAdapter1.GetCustomers();
        }
        public DataEntityTier.NorthWindDataSet.OrdersDataTable GetOrders()
        {
            DataAccessTier.NorthWindDataSetTableAdapters.OrdersTableAdapter
                 OrdersTableAdapter1
                = new DataAccessTier.NorthWindDataSetTableAdapters.OrdersTableAdapter();
            return OrdersTableAdapter1.GetOrders();
        }
    }
}
