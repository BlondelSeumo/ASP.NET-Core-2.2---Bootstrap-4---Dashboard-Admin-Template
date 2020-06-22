using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class ElementExtraController : Controller
    {
        public IActionResult Timeout()
        {
            return View();
        }

        public IActionResult Idle()
        {
            return View();
        }

        public IActionResult Offline()
        {
            return View();
        }
    }
}