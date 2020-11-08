using System;
using System.Collections.Generic;
using System.Net.Configuration;
using CRM;
using BLL;
using BOL;
namespace Membership
{
   public class customerRelationshipmanager
    {

        public static IEnumerable<Customer> GetAllCustomer()
        {
            IEnumerable<Customer> allProducts = BusinessManager.GetAllCustomer();
            return allProducts;
        }
        public static Customer GetCustomerById(int customerid)
        {
            Customer theCustomer = BusinessManager.GetCustomerById(customerid);
            return theCustomer;
        }
        public static Boolean insertCustomer(User theUser)
        {
            Customer theCustomer = new Customer
            {
                Id = theUser.Id,
                Firstname = theUser.Firstname,
                Lastname = theUser.Lastname,
                Email = theUser.Email,
                ContactNumber = theUser.ContactNumber,
                Fax = theUser.Fax,
                Address = theUser.Address,
                Zip = theUser.Zip,
                State = theUser.State,
                UserName=theUser.UserName,
                Password=theUser.Password,
                Registrationdate = DateTime.Now
            };
            return BusinessManager.insertCustomer(theCustomer);
        }
        public static Boolean deleteCustomer(int CustomerId)
        {
            return BusinessManager.deleteCustomer(CustomerId);
        }
        public static Boolean updateCustomer(Customer theCustomer)
        {
            return BusinessManager.updateCustomer(theCustomer);
        }

        public static Boolean Login(string uid, string pwd)
        {
            return BusinessManager.validate(uid, pwd);
        }
    }
}
