using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxEasy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Produto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProdutoAcabado",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entrada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoCola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Embalagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoAcabado", x => x.ProdutoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoAcabado");
        }
    }
}
