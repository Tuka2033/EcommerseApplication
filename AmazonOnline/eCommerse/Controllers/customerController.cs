using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM;
using BLL;
namespace eCommerse.Controllers
{
    public class customerController : Controller
    {
        // GET: customer
        public ActionResult Index()
        {
            IEnumerable<Customer> theCustomer = customerRelationshipmanager.GetAllCustomer();
            this.ViewBag.customer = theCustomer;
            return View();
        }
        public ActionResult Details(int id)
        {
            Customer theCustomer = customerRelationshipmanager.GetCustomerById(id);
            this.ViewBag.customer = theCustomer;
            return View();
        }
    }
}