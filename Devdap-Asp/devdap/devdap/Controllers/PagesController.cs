using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devdap.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult about()
        {
            return View();
        }

        public ActionResult blog()
        {
            return View();
        }
        public ActionResult blog_grid()
        {
            return View();
        }

        public ActionResult blog_details()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }
       
        public ActionResult portfolio()
        {
            return View();
        }
        public ActionResult portfolio_details()
        {
            return View();
        }
       
    }
}