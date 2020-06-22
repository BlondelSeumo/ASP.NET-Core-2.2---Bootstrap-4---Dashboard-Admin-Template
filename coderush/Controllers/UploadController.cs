using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult FileUpload()
        {
            return View();
        }
    }
}