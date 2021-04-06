using Microsoft.EntityFrameworkCore.Migrations;

namespace Aula2.Migrations
{
    public partial class Adicionandopropriedade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "valor",
                table: "produto",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valor",
                table: "produto");
        }
    }
}
