using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class EditorController : Controller
    {
        public IActionResult CKEditor()
        {
            return View();
        }

        public IActionResult CKEditorBallon()
        {
            return View();
        }

        public IActionResult CKEditorInline()
        {
            return View();
        }

        public IActionResult CKEditorDocument()
        {
            return View();
        }

        public IActionResult TinyMCE()
        {
            return View();
        }
    }
}