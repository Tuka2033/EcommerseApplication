
using System;
using System.Collections.Generic;
using BLL;
using OrderProcessing;
namespace Membership
{
   public class orderManager
    {
        public static Boolean Insert(Order order)
        {
            return BusinessManager.insertOrder(order);
        }
        public static Boolean Update(int orderid,Order order)
        {
            return BusinessManager.updateOrder(orderid, order);
        }
       //public void Delete(Order order)
       // {
       //     orders.Remove(order);
       // }
       
        public static IEnumerable<Order> GetAllOrder()
        {
            IEnumerable<Order> allOrder =BusinessManager.GetAllOrder();
            return allOrder;
        }
        public static Order GetOrderByID(int orderId)
        {
            Order order = BusinessManager.GetOrderByID(orderId);
            return order;
        }
        //public List<Order> GetByVendor(string vendor)
        //{
        //    List<Order> orders = new List<Order>();
        //    foreach (workOrder order in this.orders)
        //    {
        //        if (order.Vendor == vendor)
        //            return orders;
        //    }
        //    return null;
        //}
    }
}
