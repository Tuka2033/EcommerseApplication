using System;
using System.Collections.Generic;
using System.Net.Configuration;
using CRM;
using DAL;
namespace BLL
{
   public class customerRelationshipmanager
    {
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
    }
}
