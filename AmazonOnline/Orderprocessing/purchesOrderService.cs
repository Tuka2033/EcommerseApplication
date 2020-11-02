
using System.Collections.Generic;

namespace OrderProcessing
{
    public class purchesOrderService : IorderService
    {
        purchesOrderManager purchesordermanager=purchesOrderManager.GetManager();
        public bool cancal(Order order)
        {
           bool status = false;
            return status;
        }

        public void create(Order order)
        {
            //create order logic 

            purchesordermanager.insert(order);
        }

        public Order getOrder(int Orderid)
        {
            Order o=new Order();
            return o;
        }

        public List<Order> getOrders()
        {
           
            List<Order> orderList = purchesordermanager.getAll();
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
