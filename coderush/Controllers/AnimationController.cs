using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class AnimationController : Controller
    {
        public IActionResult Animation1()
        {
            return View();
        }
    }
}