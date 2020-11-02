using Catalog;
using CRM;
using OrderProcessing;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonOnline
{
    public class OrderProcessingtest
    {
        public static void main(string[] args)
        {
            Product product = new Product(101, "Rose", "Flower", 10, 200);

            Item item = new Item(product, 50);

            Cart cart = new Cart();
            cart.AddtoCart(item);
            List<Item> cart1 = cart.getAll();

            Customer customer = new Customer(100, "Tuka", "Pandhare", "Tuka@gmail.com", 1234);

            DateTime date = new DateTime(2020, 10, 27);

            Order order = new Order(cart1, 102, date, customer);

            OrderManager om = new OrderManager();

            om.insert(order);

            List<Order> Om = om.getAll();

            foreach (Order or in Om)
            {
                Console.WriteLine(or);
                foreach(Item im in or)
                {
                    Console.WriteLine(im);
                }
            }
        }
    }
}
