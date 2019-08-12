using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CTVoicer.Negocio.Migrations
{
    public partial class CTVoicer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frotas",
                columns: table => new
                {
                    IdFrota = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frotas", x => x.IdFrota);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    IdVeiculo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdFrota = table.Column<int>(nullable: false),
                    Chassi = table.Column<string>(type: "nvarchar(17)", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(10)", nullable: false),
                    NumPassageiros = table.Column<int>(nullable: false),
                    Cor = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.IdVeiculo);
                    table.ForeignKey(
                        name: "FK_Veiculos_Frotas_IdFrota",
                        column: x => x.IdFrota,
                        principalTable: "Frotas",
                        principalColumn: "IdFrota",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_IdFrota",
                table: "Veiculos",
                column: "IdFrota");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Frotas");
        }
    }
}
