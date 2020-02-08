using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Telefonia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DDD",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codigo_ddd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operadoras",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operadoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codigo_plano = table.Column<int>(nullable: false),
                    minutos = table.Column<int>(nullable: false),
                    franquia_internet = table.Column<int>(nullable: false),
                    valor = table.Column<decimal>(nullable: false),
                    tipo = table.Column<int>(nullable: false),
                    operadora_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plano_Operadoras_operadora_id",
                        column: x => x.operadora_id,
                        principalTable: "Operadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanoDDDs",
                columns: table => new
                {
                    plano_id = table.Column<long>(nullable: false),
                    ddd_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDDDs", x => new { x.plano_id, x.ddd_id });
                    table.ForeignKey(
                        name: "FK_PlanoDDDs_DDD_ddd_id",
                        column: x => x.ddd_id,
                        principalTable: "DDD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanoDDDs_Plano_plano_id",
                        column: x => x.plano_id,
                        principalTable: "Plano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plano_operadora_id",
                table: "Plano",
                column: "operadora_id");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoDDDs_ddd_id",
                table: "PlanoDDDs",
                column: "ddd_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanoDDDs");

            migrationBuilder.DropTable(
                name: "DDD");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "Operadoras");
        }
    }
}
