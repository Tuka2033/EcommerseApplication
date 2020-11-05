
using System.Collections.Generic;
using Catalog;
namespace DAL
{
   public interface IconnectedServices
    {
        Product GetProductByID(int productID);
        IEnumerable<Product> GetAllProduct();
        bool insertProduct(Product theProduct);
        bool updateProduct(Product theProduct);
        bool deleteProduct(int productID);
    }
}
