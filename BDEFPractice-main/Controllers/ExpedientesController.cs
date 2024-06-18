using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CRUDProductCatalog.Controllers
{
    public class ExpedientesController : Controller
    {
      private readonly ApplicationDbContext _context;
        public ExpedientesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult ExpedienteList()
    {
        return View();
    }
    }
    
    
}