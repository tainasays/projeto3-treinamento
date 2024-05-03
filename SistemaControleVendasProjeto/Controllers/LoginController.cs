using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaControleVendasProjeto.Models;
using System.Threading.Tasks;
using VendasProjeto.Data;

namespace SistemaControleVendasProjeto.Controllers
{
    public class LoginController : Controller
    {
        private readonly SistemaControleVendasProjetoContext _context; // Substitua 'SeuDbContext' pelo nome do seu contexto de banco de dados

        public LoginController(SistemaControleVendasProjetoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string senha)
        {
            var usuario = await _context.Usuario.FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
                      
            if (usuario != null)
            {
                string nivelAcesso = "";

                switch (usuario.NivelAcessoID)
                {
                    case 1:
                        nivelAcesso = "Administrador";
                        break;
                    case 2:
                        nivelAcesso = "Funcionário";
                        break;
                    case 3:
                        nivelAcesso = "Cliente";
                        break;
                    default:
                        nivelAcesso = "Desconhecido";
                        break;
                }

                switch (nivelAcesso)
                {
                    case "Administrador":
                        return RedirectToAction("Index", "Produtos");
                    case "Funcionário":
                        return RedirectToAction("Index", "Nivel2");
                    case "Cliente":
                        return RedirectToAction("Index", "ProdutosPedidos");
                    default:
                        return RedirectToAction("Index", "Home"); // Página padrão, se o nível de acesso for desconhecido
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Credenciais inválidas. Tente novamente.";
                return View();
            }
        }
    }
}