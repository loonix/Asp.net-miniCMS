using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniCMS.Controllers
{
    public class CMSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page(string id)
        {
            return View(id);
        }
    }
}
