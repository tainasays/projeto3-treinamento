using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaControleVendasProjeto.Migrations
{
    /// <inheritdoc />
    public partial class ConsertaProdEProdPed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoID",
                table: "ProdutoPedido",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PedidoID",
                table: "ProdutoPedido");
        }
    }
}
