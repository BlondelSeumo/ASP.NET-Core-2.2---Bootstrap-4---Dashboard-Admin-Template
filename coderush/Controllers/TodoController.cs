using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Todo()
        {
            return View();
        }

        public IActionResult Notes()
        {
            return View();
        }
    }
}