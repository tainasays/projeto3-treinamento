using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaControleVendasProjeto.Models;
using VendasProjeto.Data;

namespace SistemaControleVendasProjeto.Controllers
{
    public class ProdutosPedidosController : Controller
    {
        private readonly SistemaControleVendasProjetoContext _context;

        public ProdutosPedidosController(SistemaControleVendasProjetoContext context)
        {
            _context = context;
        }

        // GET: ProdutosPedidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdutoPedido.ToListAsync());
        }

        // GET: ProdutosPedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoPedido = await _context.ProdutoPedido
                .FirstOrDefaultAsync(m => m.ProdutoPedidoID == id);
            if (produtoPedido == null)
            {
                return NotFound();
            }

            return View(produtoPedido);
        }

        // GET: ProdutosPedidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdutosPedidos/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProdutoPedidoID,PedidoID,ProdutoID,Quantidade,Valor,DataCadastro")] ProdutoPedido produtoPedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoPedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoPedido);
        }

        // GET: ProdutosPedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoPedido = await _context.ProdutoPedido.FindAsync(id);
            if (produtoPedido == null)
            {
                return NotFound();
            }
            return View(produtoPedido);
        }

        // POST: ProdutosPedidos/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProdutoPedidoID,PedidoID,ProdutoID,Quantidade,Valor,DataCadastro")] ProdutoPedido produtoPedido)
        {
            if (id != produtoPedido.ProdutoPedidoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoPedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoPedidoExists(produtoPedido.ProdutoPedidoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produtoPedido);
        }

        // GET: ProdutosPedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoPedido = await _context.ProdutoPedido
                .FirstOrDefaultAsync(m => m.ProdutoPedidoID == id);
            if (produtoPedido == null)
            {
                return NotFound();
            }

            return View(produtoPedido);
        }

        // POST: ProdutosPedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoPedido = await _context.ProdutoPedido.FindAsync(id);
            if (produtoPedido != null)
            {
                _context.ProdutoPedido.Remove(produtoPedido);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoPedidoExists(int id)
        {
            return _context.ProdutoPedido.Any(e => e.ProdutoPedidoID == id);
        }
    }
}
