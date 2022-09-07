using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class OdaOzellikGuncelle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdaOzellik",
                table: "Odalars");

            migrationBuilder.CreateTable(
                name: "OdaOzellikSecims",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OdaId = table.Column<int>(nullable: false),
                    OzellikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaOzellikSecims", x => x.Idno);
                    table.ForeignKey(
                        name: "FK_OdaOzellikSecims_Odalars_OdaId",
                        column: x => x.OdaId,
                        principalTable: "Odalars",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdaOzellikSecims_OdaOzelliks_OzellikId",
                        column: x => x.OzellikId,
                        principalTable: "OdaOzelliks",
                        principalColumn: "Idno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OdaOzellikSecims_OdaId",
                table: "OdaOzellikSecims",
                column: "OdaId");

            migrationBuilder.CreateIndex(
                name: "IX_OdaOzellikSecims_OzellikId",
                table: "OdaOzellikSecims",
                column: "OzellikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OdaOzellikSecims");

            migrationBuilder.AddColumn<string>(
                name: "OdaOzellik",
                table: "Odalars",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
