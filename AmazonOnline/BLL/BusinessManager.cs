using System;
using System.Collections.Generic;
using Catalog;
using DAL;
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

        public static Boolean Insert(Product theproduct)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.Insert(theproduct);
        }
        public static Boolean Delete(int ProductId)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.Delete(ProductId);
        }
        public static Boolean Update(Product theProduct)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.update(theProduct);
        }

        public static Product GetProduct(int id)
        {
            IconnectedServices mgr = new DbManagerConnected();
            return mgr.GetProductByID(id);
        }
    }
}
