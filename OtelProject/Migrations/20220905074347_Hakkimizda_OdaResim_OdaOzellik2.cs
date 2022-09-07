using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class Hakkimizda_OdaResim_OdaOzellik2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hakkimizdas",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(nullable: true),
                    AltBaslik = table.Column<string>(nullable: true),
                    Icerik = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimizdas", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "OdaOzelliks",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ikon = table.Column<string>(nullable: true),
                    Baslik = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaOzelliks", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "OdaResims",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OdaId = table.Column<int>(nullable: false),
                    Resim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaResims", x => x.Idno);
                    table.ForeignKey(
                        name: "FK_OdaResims_Odalars_OdaId",
                        column: x => x.OdaId,
                        principalTable: "Odalars",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OdaResims_OdaId",
                table: "OdaResims",
                column: "OdaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hakkimizdas");

            migrationBuilder.DropTable(
                name: "OdaOzelliks");

            migrationBuilder.DropTable(
                name: "OdaResims");
        }
    }
}
