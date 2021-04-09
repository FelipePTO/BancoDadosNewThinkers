using Microsoft.EntityFrameworkCore.Migrations;

namespace Aula2.Migrations
{
    public partial class Adicionandoatributotamanho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tamanho",
                table: "produto",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tamanho",
                table: "produto");
        }
    }
}
