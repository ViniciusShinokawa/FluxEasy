using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxEasy.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProdutoPva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstoquePVA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Produtos = table.Column<int>(type: "int", nullable: false),
                    Frascos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Galoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bc10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bc50 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoquePVA", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstoquePVA");
        }
    }
}
