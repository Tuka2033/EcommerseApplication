using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Membership;
using CRM;
using BOL;
namespace eCommerse.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {

            bool status = customerRelationshipmanager.Login(username, password);
            if (status)
            {
                return this.RedirectToAction("index", "catalog");

            }

            return View();

        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(int id, string firstName, string lastName, string email, string contactNumber, string fax, string address, string zip, string state, string loginname, string password)
        {
           User theUser = new User
            {
                Id = id,
                Firstname = firstName,
                Lastname = lastName,
                Email = email,
                ContactNumber = contactNumber,
                Fax = fax,
                Address = address,
                Zip = zip,
                State = state,
                UserName=loginname,
                Password=password
            };
            bool status = customerRelationshipmanager.insertCustomer(theUser);
            return View();
        }
    }
}