using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaControleVendasProjeto.Migrations
{
    /// <inheritdoc />
    public partial class SegundaTentativa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PedidoID",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Pedido");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoID",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Pedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Pedido",
                type: "float",
                nullable: true);
        }
    }
}
