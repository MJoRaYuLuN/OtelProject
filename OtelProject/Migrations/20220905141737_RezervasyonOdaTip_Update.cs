using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class RezervasyonOdaTip_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdaTipId",
                table: "Rezervasyons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_OdaTipId",
                table: "Rezervasyons",
                column: "OdaTipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyons_OdaTips_OdaTipId",
                table: "Rezervasyons",
                column: "OdaTipId",
                principalTable: "OdaTips",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyons_OdaTips_OdaTipId",
                table: "Rezervasyons");

            migrationBuilder.DropIndex(
                name: "IX_Rezervasyons_OdaTipId",
                table: "Rezervasyons");

            migrationBuilder.DropColumn(
                name: "OdaTipId",
                table: "Rezervasyons");
        }
    }
}
