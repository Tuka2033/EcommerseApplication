
using System.Collections.Generic;

namespace OrderProcessing
{
    public interface IorderService
    {
        bool process(Order order);
        void create(Order order);
        bool cancal(Order order);
        Order  getOrder(int Orderid);
        List<Order> getOrders();
        bool update(Order order);
    }
}
