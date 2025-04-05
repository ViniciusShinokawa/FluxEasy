using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluxEasy.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEstoquePVA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Entrada",
                table: "EstoquePVA",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "EstoquePVA");
        }
    }
}
