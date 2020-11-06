using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catalog;
using BLL;

namespace eCommerse.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            IEnumerable<Product> allProducts = BusinessManager.GetAllProducts();
            this.ViewBag.products = allProducts;
            return View();
        }
        public ActionResult Details(int id)
        {
            Product theProduct = BusinessManager.GetProduct(id);
            this.ViewBag.product = theProduct;
            return View();
        }
    }
}