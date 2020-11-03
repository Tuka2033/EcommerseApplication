using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using DAL;
namespace BLL
{
    public class BusinessManager
    {
        public static IEnumerable<Product> GetAllProducts()
        {

            IEnumerable<Product> allProducts =DbManagers.GetAllProduct();
            return allProducts;
        }

        public static Boolean Insert(Product theproduct)
        {
            return DbManagers.Insert(theproduct);
        }
    }
}
