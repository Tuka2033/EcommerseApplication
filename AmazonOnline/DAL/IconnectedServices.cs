
using System.Collections.Generic;
using Catalog;
namespace DAL
{
   public interface IconnectedServices
    {
        Product GetProductByID(int productID);
        IEnumerable<Product> GetAllProduct();
        bool Insert(Product theProduct);
        bool update(Product theProduct);
        bool Delete(int productID);
    }
}
