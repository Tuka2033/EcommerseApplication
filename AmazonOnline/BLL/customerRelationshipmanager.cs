using System;
using CRM;
using DAL;
namespace BLL
{
    class customerRelationshipmanager
    {
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
