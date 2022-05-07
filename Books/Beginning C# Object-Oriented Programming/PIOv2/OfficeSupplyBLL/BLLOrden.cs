using System.Collections.ObjectModel;

namespace OfficeSupplyBLL
{
    public class BLLOrden
    {

        ObservableCollection<BLLItem> _orderItemList = new
            ObservableCollection<BLLItem>();

        public ObservableCollection<BLLItem> ItemsList
        {
            get { return _orderItemList; }
        }
        public void AddItem(BLLItem orderItem)
        {
            foreach (var item in _orderItemList)
            {
                if (item.ProdID == orderItem.ProdID)
                {
                    item.Quantity += orderItem.Quantity;

                    return;
                }
            }
            _orderItemList.Add(orderItem);
        }
        public void RemoveItem(string productID)
        {
            foreach (var item in _orderItemList)
            {
                if (item.ProdID == productID)
                {
                    _orderItemList.Remove(item);
                    return;
                }
            }
        }
        public double GetOrderTotal()
        {
            if (_orderItemList.Count == 0)
            {
                return 0.00;
            }
            else
            {
                double total = 0;
                foreach (var item in _orderItemList)
                {
                    total += item.SubTotal;
                }
                return total;
            }
        }
        public int PlaceOrder(int employeeID)
        {
            string xmlOrder;
            xmlOrder = "<Order EmployeeID='" + employeeID.ToString() + "'>";
            foreach (var item in _orderItemList)
            {
                xmlOrder += item.ToString();
            }
            xmlOrder += "</Order>";
            DALOrden dbOrder = new DALOrden();
            return dbOrder.PlaceOrder(xmlOrder);
        }
    }
}