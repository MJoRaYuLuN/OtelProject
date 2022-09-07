using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class Hakkimizda_OdaResim_OdaOzellik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OdaOzellik",
                table: "Odalars",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdaOzellik",
                table: "Odalars");
        }
    }
}
