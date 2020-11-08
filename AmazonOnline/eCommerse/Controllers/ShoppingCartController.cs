using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart;
namespace eCommerse.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            Cart theCart = this.Session["cart"] as Cart;
            int itemCount = theCart.Items.Count;
            return View();
        }
        public ActionResult AddToCart(string productID)
        {
            //Get shopping cart from session
            Cart theCart = this.Session["cart"] as Cart;
            //add item to cart maintained session variable
            //
            return View();
        }
        public ActionResult RemoveFromCart(int productID)
        {
            //Get shopping cart from session
            //remove item  from the cart maintained session variable
            //
            return View();
        }
    }
}