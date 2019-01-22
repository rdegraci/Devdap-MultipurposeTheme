using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace devdap_core.Controllers
{
    public class HeadersController : Controller
    {
        public IActionResult gradients()
        {
            return View();

        }
        public IActionResult solid()
        {
            return View();
        }
        public IActionResult parallax()
        {
            return View();

        }
        public IActionResult typing()
        {
            return View();
        }
        public IActionResult background()
        {
            return View();
        }
    }
}