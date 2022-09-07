using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class ActUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Act",
                table: "OdaResims",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Act",
                table: "OdaOzelliks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Act",
                table: "OdaResims");

            migrationBuilder.DropColumn(
                name: "Act",
                table: "OdaOzelliks");
        }
    }
}
