using System;
using System.Collections.Generic;
using Catalog;
using DAL;
using CRM;
using OrderProcessing;
namespace BLL
{
    public static class BusinessManager
    {
        public static IEnumerable<Product> GetAllProducts()
        {
            IconnectedServices mgr = new DbManagerConnected();
            IEnumerable<Product> allProducts =mgr.GetAllProduct();
            return allProducts;
        }

        public static Boolean insertproduct(Product theproduct)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.insertProduct(theproduct);
        }
        public static Boolean deleteproduct(int ProductId)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.deleteProduct(ProductId);
        }
        public static Boolean updateproduct(Product theProduct)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.updateProduct(theProduct);
        }

        public static Product GetProduct(int id)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.GetProductByID(id);
        }

        //Customer Related
        public static IEnumerable<Customer> GetAllCustomer()
        {
            Icustomer mgr = new DbCustomer();
            IEnumerable<Customer> allProducts = mgr.GetAllCustomer();
            return allProducts;
        }
        public static Customer GetCustomerById(int customerid)
        {
            Icustomer mgr = new DbCustomer();
            Customer theCustomer = mgr.GetCustomerByID(customerid);
            return theCustomer;
        }
        public static Boolean insertCustomer(Customer theCustomer)
        {
            Icustomer mgr = new DbCustomer();
            return mgr.insertCustomer(theCustomer);
        }
        public static Boolean deleteCustomer(int CustomerId)
        {
            Icustomer mgr = new DbCustomer();
            return mgr.deleteCustomer(CustomerId);
        }
        public static Boolean updateCustomer(Customer theCustomer)
        {
            Icustomer mgr = new DbCustomer();
            return mgr.updateCustomer(theCustomer);
        }

        //Order Related
        public static IEnumerable<Order> GetAllOrder()
        {
            Iorder order = new Dborder();
            IEnumerable<Order> allOrder = order.GetAllOrder();
            return allOrder;
        }
        public static Order GetOrderByID(int orderid)
        {
            Iorder order = new Dborder();
            Order theOrder = order.GetOrderByOrderID(orderid);
            return theOrder;
        }
        public static Boolean insertOrder(Order order)
        {

            return false;
        }
        public static Boolean updateOrder(int orderid,Order order)
        {
            return true;
        }
        public static Boolean validate(string uid,string pwd)
        {
            Icustomer mgr = new DbCustomer();
            bool status =mgr.Validate(uid,pwd);
            return status;
        }
    }
}
