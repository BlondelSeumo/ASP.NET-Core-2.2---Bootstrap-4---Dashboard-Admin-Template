using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coderush.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Invoice()
        {
            return View();
        }

        public IActionResult InvoiceSummary()
        {
            return View();
        }

        public IActionResult InvoiceList()
        {
            return View();
        }
    }
}