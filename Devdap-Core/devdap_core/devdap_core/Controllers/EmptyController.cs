using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace devdap_core.Controllers
{
    public class EmptyController : Controller
    {
        public IActionResult login()
        {
            return View("login", "_Empty_Layout");
        }
        public IActionResult register()
        {
            return View("register", "_Empty_Layout");
        }
        public IActionResult error()
        {
            return View("error", "_Empty_Layout");
        }

        public IActionResult comming_soon()
        {
            return View("comming_soon", "_Empty_Layout");
        }

    }
}