using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaControleVendasProjeto.Models;

namespace VendasProjeto.Data
{
    public class SistemaControleVendasProjetoContext : DbContext
    {
        public SistemaControleVendasProjetoContext (DbContextOptions<SistemaControleVendasProjetoContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaControleVendasProjeto.Models.CategoriaProduto> CategoriaProduto { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.FormaPagamento> FormaPagamento { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.Produto> Produto { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.ProdutoPedido> ProdutoPedido { get; set; } = default!;
        public DbSet<SistemaControleVendasProjeto.Models.Usuario> Usuario { get; set; } = default!;
    }
}
