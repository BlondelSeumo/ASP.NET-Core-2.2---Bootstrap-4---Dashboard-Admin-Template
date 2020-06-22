using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class MaintenanceController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult ComingSoon()
        {
            return View();
        }

        public IActionResult OfflineUI()
        {
            return View();
        }
    }
}