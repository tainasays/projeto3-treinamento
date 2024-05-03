using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendasProjeto.Data;

namespace SistemaControleVendasProjeto.Controllers
{
    public class Nivel2Controller : Controller
    {
        private readonly SistemaControleVendasProjetoContext _context;

        public Nivel2Controller(SistemaControleVendasProjetoContext context)
        {
            _context = context;
        }

        // GET: Nivel2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pedido.ToListAsync());
        }

        // GET: Nivel2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido.FirstOrDefaultAsync(m => m.PedidoID == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
    }
}