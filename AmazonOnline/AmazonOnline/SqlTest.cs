using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using BLL;
using DAL;
namespace AmazonOnline
{
    class SqlTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  database connectivity Program");

            //IEnumerable<Product> allProducts = BusinessManager.GetAllProducts();
            //foreach (Product product in allProducts)
            //{
            //    Console.WriteLine("Title = {0},  Quantity= {1}", product.Title, product.Quantity);
            //   // Console.WriteLine("Description = {0}", product.Description);
            //}

            Product theProduct = new Product(5, "Rose", "Flower", 20, 2000);
            bool status = BusinessManager.insertproduct(theProduct);
             //bool status = BusinessManager.deleteproduct(71);
            //Product theProduct = new Product(71, "Rose", "Flower", 20, 2000);
            //bool status = BusinessManager.updateproduct(theProduct);
            Console.ReadLine();
        }
    }
}
