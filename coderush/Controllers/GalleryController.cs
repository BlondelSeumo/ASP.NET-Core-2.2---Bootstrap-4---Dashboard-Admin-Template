using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Grid()
        {
            return View();
        }

        public IActionResult Masonry()
        {
            return View();
        }

        public IActionResult GridAdvance()
        {
            return View();
        }
    }
}