using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult VerticalStatic()
        {
            return View();
        }

        public IActionResult VerticalFixed()
        {
            return View();
        }

        public IActionResult VerticalNavbarFixed()
        {
            return View();
        }

        public IActionResult VerticalCollapseMenu()
        {
            return View();
        }

        public IActionResult LightLayout()
        {
            return View();
        }

        public IActionResult DarkLayout()
        {
            return View();
        }

        public IActionResult ColorIcon()
        {
            return View();
        }
    }
}