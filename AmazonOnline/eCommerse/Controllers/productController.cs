using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Catalog;
using BLL;
namespace eCommerse.Controllers
{
    public class productController : ApiController
    {
        // GET: api/product
        public IEnumerable<Product> Get()
        {
            return BusinessManager.GetAllProducts();
        }

        // GET: api/product/5
        public Product Get(int id)
        {
            return BusinessManager.GetProduct(id);
        } 

        // POST: api/product
        public void Post([FromBody]Product value)
        {
            bool status = BusinessManager.insertproduct(value);
        }

        // PUT: api/product/5
        public void Put(int id, [FromBody]Product value)
        {
            bool status = BusinessManager.updateproduct(value);
        }

        // DELETE: api/product/5
        public void Delete(int id)
        {
        bool status= BusinessManager.deleteproduct(id);
        }
    }
}
