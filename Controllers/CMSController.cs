using Microsoft.AspNetCore.Mvc;
using miniCMS.Data;
using System.Linq;

namespace miniCMS.Controllers
{
    public class CMSController : Controller
    {
        private readonly DbMiniCMSContext _context;
        public CMSController(DbMiniCMSContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Page(string id)
        {
            // recuperar da BD miniCMS da tabela Conteudo, o registo cujo campo Pagina = id
            var pagina = _context.Conteudos.FirstOrDefault(m => m.Pagina == id);
            if (pagina == null)
            {
                return NotFound();
            }
            return View(pagina);
        }
    }


}
