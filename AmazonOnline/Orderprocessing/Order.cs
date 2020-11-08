
using System;
using System.ComponentModel;

namespace OrderProcessing
{
    public class Order
    {
        public float Amount { get; set; }
        public int CusomerId {get;set;}
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public Order() { }
        public Order(int  orderId,DateTime orderdate,float amount,int customerid)
        {
            this.OrderID = orderId;
            this.OrderDate = orderdate;
            this.CusomerId = customerid;
            this.Amount = amount;
        }
    }

}
