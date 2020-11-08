using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Membership;
using OrderProcessing;
namespace eCommerse.Controllers
{
    public class orderController : Controller
    {
        // GET: order
        public ActionResult Index()
        {
            IEnumerable<Order> allOrders = orderManager.GetAllOrder();
            this.ViewBag.Orders = allOrders;
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}