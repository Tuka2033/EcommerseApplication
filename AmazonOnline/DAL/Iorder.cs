using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessing;
namespace DAL
{
    public interface Iorder
    {
        Order GetOrderByOrderID(int orderID);
        IEnumerable<Order> GetAllOrder();
        IEnumerable<Order> GetAllOrderByCustomerId(int customerId);
        bool insertOrder(Order theOrder);
       // bool updateOrder(Order theOrder);
      //  bool deleteOrderByOrderId(int orderid);
    }
}
