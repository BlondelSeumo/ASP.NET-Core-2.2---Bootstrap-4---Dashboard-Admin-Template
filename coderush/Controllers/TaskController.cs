using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult TaskList()
        {
            return View();
        }

        public IActionResult TaskBoard()
        {
            return View();
        }

        public IActionResult TaskDetail()
        {
            return View();
        }
    }
}