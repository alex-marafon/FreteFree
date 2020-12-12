using Microsoft.EntityFrameworkCore.Migrations;

namespace FreteFree.Migrations
{
    public partial class Migracao03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "OrdemCarregamento",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Motorista",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Empresa",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "OrdemCarregamento");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Motorista");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Empresa");
        }
    }
}
