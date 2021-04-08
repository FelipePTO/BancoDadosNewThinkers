using Microsoft.EntityFrameworkCore.Migrations;

namespace aula2.Migrations
{
    public partial class adicionandovalor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "valor",
                table: "produto",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valor",
                table: "produto");
        }
    }
}
