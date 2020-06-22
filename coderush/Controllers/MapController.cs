using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class MapController : Controller
    {
        public IActionResult GoogleMap()
        {
            return View();
        }

        public IActionResult Vector()
        {
            return View();
        }

        public IActionResult GMapSearch()
        {
            return View();
        }
        
    }
}