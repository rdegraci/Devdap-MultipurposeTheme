using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace devdap.Controllers
{
    public class EmptyController : Controller
    {
        public ActionResult login()
        {
          return View("login", "_Empty_Layout");
        }
        public ActionResult register()
        {
            return View("register", "_Empty_Layout");
        }
        public ActionResult error()
        {
            return View("error", "_Empty_Layout");
        }

        public ActionResult comming_soon()
        {
            return View("comming_soon", "_Empty_Layout");
        }

    }
}