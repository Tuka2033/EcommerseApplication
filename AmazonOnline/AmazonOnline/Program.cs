using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using CRM;
using OrderProcessing;
using ShoppingCart;
using Banking;
using Membership;
//using ShoppingCart;

namespace AmazonOnline
{
    public class Program
    {
        static void Main(string[] args)
        {
            //product
            Product product = new Product(101, "Rose", "Flower", 10, 200);

            //item
            Item item = new Item(product, 50);

            //cart
            Cart cart = new Cart();
            cart.AddtoCart(item);
            List<Item> cart1 = cart.getAll();

            //customer
            Customer customer = new Customer(100, "Tuka", "Pandhare", "Tuka@gmail.com", 1234);

            //date
            DateTime date = new DateTime(2020, 10, 27);

            //order
            Order order = new Order(cart1, 102, date, customer);

            //service
            IorderService service = new purchesOrderService();
            service.create(order);

            //ordermanager
            // OrderManager om = new OrderManager();

            // om.insert(order);

            List<Order> Om = service.getOrders();

            foreach (Order or in Om)
            {

                Console.Write(or.OrderId + " ");
                Console.Write(or.OrderDate1 + " ");
                Console.Write(or.Cust.Firstname + " ");
                Console.Write(or.Cust.ContactNumber + " ");
                foreach (Item im in or.Items)
                {
                    Console.Write(im.theProduct.Title + " ");
                    Console.Write(im.theProduct.UnitPrice + " ");
                    Console.WriteLine(im.Quantity + " ");
                }
            }
        }

    }
}
