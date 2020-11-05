using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;
namespace DAL
{
   public interface Icustomer
    {
        bool insertCustomer(Customer theCustomer);
        bool updateCustomer(Customer theCustomer);
        bool deleteCustomer(int id);
    }
}
