using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreteFree.Migrations
{
    public partial class Migracao01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdemCarregamento",
                columns: table => new
                {
                    OrdemCarregamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    MotoristaId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    Medida = table.Column<int>(type: "int", nullable: false),
                    DataOrdemCarregamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemCarregamento", x => x.OrdemCarregamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeResponsavel = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    TelefoneEmpresa = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CidadeEmpresa = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    OrdemCarregamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                    table.ForeignKey(
                        name: "FK_Empresa_OrdemCarregamento_OrdemCarregamentoId",
                        column: x => x.OrdemCarregamentoId,
                        principalTable: "OrdemCarregamento",
                        principalColumn: "OrdemCarregamentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motorista",
                columns: table => new
                {
                    MotoristaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaminhaoProprietario = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EnderecoProprietario = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    TelefoneProprietario = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    TipoCaminhao = table.Column<int>(type: "int", nullable: false),
                    PlacaCavalo = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CidadeCavalo = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EstadoCavalo = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    PlacaCarreta = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    CidadeCarreta = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EstadoCarreta = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    NomeMotorista = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    EnderecoMotorista = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    TelefoneMovel = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    TelefoneFixo = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    CidadeMotorista = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    UF = table.Column<int>(type: "int", nullable: false),
                    CPFMotorista = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    RGMotorista = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    CNPJ = table.Column<decimal>(type: "decimal(20)", nullable: false),
                    OrdemCarregamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorista", x => x.MotoristaId);
                    table.ForeignKey(
                        name: "FK_Motorista_OrdemCarregamento_OrdemCarregamentoId",
                        column: x => x.OrdemCarregamentoId,
                        principalTable: "OrdemCarregamento",
                        principalColumn: "OrdemCarregamentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_OrdemCarregamentoId",
                table: "Empresa",
                column: "OrdemCarregamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorista_OrdemCarregamentoId",
                table: "Motorista",
                column: "OrdemCarregamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemCarregamento_EmpresaId",
                table: "OrdemCarregamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemCarregamento_MotoristaId",
                table: "OrdemCarregamento",
                column: "MotoristaId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemCarregamento_Empresa_EmpresaId",
                table: "OrdemCarregamento",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "EmpresaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemCarregamento_Motorista_MotoristaId",
                table: "OrdemCarregamento",
                column: "MotoristaId",
                principalTable: "Motorista",
                principalColumn: "MotoristaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_OrdemCarregamento_OrdemCarregamentoId",
                table: "Empresa");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorista_OrdemCarregamento_OrdemCarregamentoId",
                table: "Motorista");

            migrationBuilder.DropTable(
                name: "OrdemCarregamento");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Motorista");
        }
    }
}
