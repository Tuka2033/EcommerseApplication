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
    }
}
