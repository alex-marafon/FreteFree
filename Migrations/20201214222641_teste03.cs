using Microsoft.EntityFrameworkCore.Migrations;

namespace FreteFree.Migrations
{
    public partial class teste03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UF",
                table: "Motorista",
                newName: "EstadoMotorista");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoCavalo",
                table: "Motorista",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoCarreta",
                table: "Motorista",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstadoMotorista",
                table: "Motorista",
                newName: "UF");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoCavalo",
                table: "Motorista",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoCarreta",
                table: "Motorista",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
