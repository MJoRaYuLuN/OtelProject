using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class RezervasyonYetiskinCocuk_ADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cocuk",
                table: "Rezervasyons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Yetiskin",
                table: "Rezervasyons",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cocuk",
                table: "Rezervasyons");

            migrationBuilder.DropColumn(
                name: "Yetiskin",
                table: "Rezervasyons");
        }
    }
}
