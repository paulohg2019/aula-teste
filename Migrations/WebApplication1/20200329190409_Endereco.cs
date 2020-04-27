using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations.WebApplication1
{
    public partial class Endereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Coment",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Cliente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coment",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Cliente");
        }
    }
}
