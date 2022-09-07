using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OtelProject.Migrations
{
    public partial class FirstDbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AltMusteris",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MusteriId = table.Column<int>(nullable: false),
                    AdiSoyadi = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    TCNo = table.Column<string>(nullable: true),
                    Uyruk = table.Column<string>(nullable: true),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltMusteris", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Adisoyadi = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    TCNo = table.Column<string>(nullable: true),
                    Uyruk = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "Odalars",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OdaAdi = table.Column<string>(nullable: true),
                    OdaNo = table.Column<int>(nullable: false),
                    OdaTip = table.Column<int>(nullable: false),
                    Cephe = table.Column<string>(nullable: true),
                    YatakSayisi = table.Column<int>(nullable: false),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odalars", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "OdaTips",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(nullable: true),
                    Ozellikler = table.Column<string>(nullable: true),
                    Ucret = table.Column<double>(nullable: false),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaTips", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "Pansiyons",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Baslik = table.Column<string>(nullable: true),
                    Ucret = table.Column<double>(nullable: false),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pansiyons", x => x.Idno);
                });

            migrationBuilder.CreateTable(
                name: "Rezervasyons",
                columns: table => new
                {
                    Idno = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MusteriId = table.Column<int>(nullable: false),
                    OdaId = table.Column<int>(nullable: false),
                    GirisTarihi = table.Column<DateTime>(nullable: false),
                    CikisTarihi = table.Column<DateTime>(nullable: false),
                    Ucret = table.Column<double>(nullable: false),
                    Pansiyon = table.Column<int>(nullable: false),
                    EkUcret = table.Column<double>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Act = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyons", x => x.Idno);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltMusteris");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Odalars");

            migrationBuilder.DropTable(
                name: "OdaTips");

            migrationBuilder.DropTable(
                name: "Pansiyons");

            migrationBuilder.DropTable(
                name: "Rezervasyons");
        }
    }
}
