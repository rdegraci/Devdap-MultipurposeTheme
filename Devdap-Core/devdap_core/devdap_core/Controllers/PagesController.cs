using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace devdap_core.Controllers
{
    public class PagesController : Controller
    {
       
        public IActionResult about()
        {
            return View();
        }

        public IActionResult blog()
        {
            return View();
        }
        public IActionResult blog_grid()
        {
            return View();
        }

        public IActionResult blog_details()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }

        public IActionResult portfolio()
        {
            return View();
        }
        public IActionResult portfolio_details()
        {
            return View();
        }
    }
}