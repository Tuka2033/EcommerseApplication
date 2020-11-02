using System.Collections.Generic;
namespace OrderProcessing
{
    public class purchesOrderManager
    {
        List<Order> orders = new List<Order>();
        private static purchesOrderManager _ref=null;

        private purchesOrderManager()
        {

        }

        public static purchesOrderManager GetManager()
        {
            if(_ref==null)
            {
                _ref = new purchesOrderManager();
                return _ref;
            }
            else {
                return _ref;
            }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public void insert(Order order)
        {
            orders.Add(order);
        }
        public void Update(Order order)
        {
            foreach (Order ord in this.orders)
            {
                if (ord.OrderID == order.OrderID)
                    orders.Add(order);
            }
        }
        public void Delete(Order order)
        {
            orders.Remove(order);
        }
        public List<Order> getAll()
        {
            return orders;
        }
        public Order GetOrderByID(int orderId)
        {
            foreach (Order order in this.orders)
            {
                if (order.OrderID == orderId)
                    return order;
            }
            return null;
        }
        public List<Order> GetByCustomerID(int custid)
        {
            List<Order> orders = new List<Order>();
            foreach (purchaseOrder order in this.orders)
            {
                if (order.theCustomer.Id == custid)
                    return orders;
            }
            return null;
        }
    }
}
