using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class tabloIliskilendirme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_MusteriId",
                table: "Rezervasyons",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_OdaId",
                table: "Rezervasyons",
                column: "OdaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_Pansiyon",
                table: "Rezervasyons",
                column: "Pansiyon");

            migrationBuilder.CreateIndex(
                name: "IX_Odalars_OdaTip",
                table: "Odalars",
                column: "OdaTip");

            migrationBuilder.CreateIndex(
                name: "IX_AltMusteris_MusteriId",
                table: "AltMusteris",
                column: "MusteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_AltMusteris_Musteris_MusteriId",
                table: "AltMusteris",
                column: "MusteriId",
                principalTable: "Musteris",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_OdaTips_OdaTip",
                table: "Odalars",
                column: "OdaTip",
                principalTable: "OdaTips",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyons_Musteris_MusteriId",
                table: "Rezervasyons",
                column: "MusteriId",
                principalTable: "Musteris",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyons_Odalars_OdaId",
                table: "Rezervasyons",
                column: "OdaId",
                principalTable: "Odalars",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyons_Pansiyons_Pansiyon",
                table: "Rezervasyons",
                column: "Pansiyon",
                principalTable: "Pansiyons",
                principalColumn: "Idno",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AltMusteris_Musteris_MusteriId",
                table: "AltMusteris");

            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_OdaTips_OdaTip",
                table: "Odalars");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyons_Musteris_MusteriId",
                table: "Rezervasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyons_Odalars_OdaId",
                table: "Rezervasyons");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyons_Pansiyons_Pansiyon",
                table: "Rezervasyons");

            migrationBuilder.DropIndex(
                name: "IX_Rezervasyons_MusteriId",
                table: "Rezervasyons");

            migrationBuilder.DropIndex(
                name: "IX_Rezervasyons_OdaId",
                table: "Rezervasyons");

            migrationBuilder.DropIndex(
                name: "IX_Rezervasyons_Pansiyon",
                table: "Rezervasyons");

            migrationBuilder.DropIndex(
                name: "IX_Odalars_OdaTip",
                table: "Odalars");

            migrationBuilder.DropIndex(
                name: "IX_AltMusteris_MusteriId",
                table: "AltMusteris");
        }
    }
}
