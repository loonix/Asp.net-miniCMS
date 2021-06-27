using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miniCMS.Data;
using miniCMS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace miniCMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbMiniCMSContext _context;


        public HomeController(ILogger<HomeController> logger, DbMiniCMSContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // recuperar da BD miniCMS da tabela Conteudo, o registo cujo campo Pagina = "Home"
            var paginaHome = _context.Conteudos.FirstOrDefault(m => m.Pagina == "Home");
            if (paginaHome == null)
            {
                return NotFound();
            }
            return View(paginaHome);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
