using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Bootstrap()
        {
            return View();
        }

        public IActionResult Datatable()
        {
            return View();
        }
        
    }
}