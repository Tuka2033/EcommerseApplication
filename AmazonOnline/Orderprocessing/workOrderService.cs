
using System.Collections.Generic;


namespace OrderProcessing
{
    public class workOrderService : IorderService
    {
        orderDeliveryManager orderdelivermanager = orderDeliveryManager.GetManager();
        public workOrderService()
        {
        }

        public bool cancal(Order order)
        {
            bool status = false;

            return status;
        }
        public void create(Order order)
        {
            orderdelivermanager.Insert(order);
        }

        public Order getOrder(int Orderid)
        {
            Order o = new Order();
            return o;
        }

        public List<Order> getOrders()
        {
            List<Order> orderList = orderdelivermanager.getAll();
            return orderList;
        }

        public bool process(Order order)
        {
            bool status = false;
            return status;
        }

        public bool update(Order order)
        {
            bool status = false;

            return status;
        }

       
    }
}
