using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaControleVendasProjeto.Migrations
{
    /// <inheritdoc />
    public partial class AddDataCadastroEmProdutosEProdutosPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "ProdutoPedido",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Produto",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "ProdutoPedido");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Produto");
        }
    }
}
