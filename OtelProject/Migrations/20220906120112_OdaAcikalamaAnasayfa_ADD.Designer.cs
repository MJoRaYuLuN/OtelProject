// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtelProject.Data.Models;

namespace OtelProject.Migrations
{
    [DbContext(typeof(MysqlContext))]
    [Migration("20220906120112_OdaAcikalamaAnasayfa_ADD")]
    partial class OdaAcikalamaAnasayfa_ADD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OtelProject.Data.Models.AltMusteri", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<string>("AdiSoyadi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("TCNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Uyruk")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Idno");

                    b.HasIndex("MusteriId");

                    b.ToTable("AltMusteris");
                });

            modelBuilder.Entity("OtelProject.Data.Models.Hakkimizda", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AltBaslik")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Baslik")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Icerik")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Idno");

                    b.ToTable("Hakkimizdas");
                });

            modelBuilder.Entity("OtelProject.Data.Models.Musteri", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<string>("Adisoyadi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TCNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Telefon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Uyruk")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Idno");

                    b.ToTable("Musteris");
                });

            modelBuilder.Entity("OtelProject.Data.Models.OdaOzellik", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<string>("Baslik")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Ikon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Idno");

                    b.ToTable("OdaOzelliks");
                });

            modelBuilder.Entity("OtelProject.Data.Models.OdaOzellikSecim", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OdaId")
                        .HasColumnType("int");

                    b.Property<int>("OzellikId")
                        .HasColumnType("int");

                    b.HasKey("Idno");

                    b.HasIndex("OdaId");

                    b.HasIndex("OzellikId");

                    b.ToTable("OdaOzellikSecims");
                });

            modelBuilder.Entity("OtelProject.Data.Models.OdaResim", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<int>("OdaId")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Idno");

                    b.HasIndex("OdaId");

                    b.ToTable("OdaResims");
                });

            modelBuilder.Entity("OtelProject.Data.Models.OdaTip", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<string>("Baslik")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Ozellikler")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Ucret")
                        .HasColumnType("double");

                    b.HasKey("Idno");

                    b.ToTable("OdaTips");
                });

            modelBuilder.Entity("OtelProject.Data.Models.Odalar", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<bool>("Anasayfa")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cephe")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("OdaAdi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("OdaNo")
                        .HasColumnType("int");

                    b.Property<int>("OdaTip")
                        .HasColumnType("int");

                    b.Property<string>("Ozellikler")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("YatakSayisi")
                        .HasColumnType("int");

                    b.HasKey("Idno");

                    b.HasIndex("OdaTip");

                    b.ToTable("Odalars");
                });

            modelBuilder.Entity("OtelProject.Data.Models.Pansiyon", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<string>("Baslik")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Ucret")
                        .HasColumnType("double");

                    b.HasKey("Idno");

                    b.ToTable("Pansiyons");
                });

            modelBuilder.Entity("OtelProject.Data.Models.Rezervasyon", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Cocuk")
                        .HasColumnType("int");

                    b.Property<double>("EkUcret")
                        .HasColumnType("double");

                    b.Property<DateTime>("GirisTarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<int>("OdaId")
                        .HasColumnType("int");

                    b.Property<int>("OdaTipId")
                        .HasColumnType("int");

                    b.Property<int>("Pansiyon")
                        .HasColumnType("int");

                    b.Property<double>("Ucret")
                        .HasColumnType("double");

                    b.Property<int>("Yetiskin")
                        .HasColumnType("int");

                    b.HasKey("Idno");

                    b.HasIndex("MusteriId");

                    b.HasIndex("OdaId");

                    b.HasIndex("OdaTipId");

                    b.HasIndex("Pansiyon");

                    b.ToTable("Rezervasyons");
                });

            modelBuilder.Entity("OtelProject.Data.Models.Yonetici", b =>
                {
                    b.Property<int>("Idno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Act")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Idno");

                    b.ToTable("Yoneticis");
                });

            modelBuilder.Entity("OtelProject.Data.Models.AltMusteri", b =>
                {
                    b.HasOne("OtelProject.Data.Models.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OtelProject.Data.Models.OdaOzellikSecim", b =>
                {
                    b.HasOne("OtelProject.Data.Models.Odalar", "Odalar")
                        .WithMany()
                        .HasForeignKey("OdaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelProject.Data.Models.OdaOzellik", "OdaOzellik")
                        .WithMany()
                        .HasForeignKey("OzellikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OtelProject.Data.Models.OdaResim", b =>
                {
                    b.HasOne("OtelProject.Data.Models.Odalar", "Odalar")
                        .WithMany()
                        .HasForeignKey("OdaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OtelProject.Data.Models.Odalar", b =>
                {
                    b.HasOne("OtelProject.Data.Models.OdaTip", "OdaTips")
                        .WithMany()
                        .HasForeignKey("OdaTip")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OtelProject.Data.Models.Rezervasyon", b =>
                {
                    b.HasOne("OtelProject.Data.Models.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelProject.Data.Models.Odalar", "Odalar")
                        .WithMany()
                        .HasForeignKey("OdaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelProject.Data.Models.OdaTip", "OdaTip")
                        .WithMany()
                        .HasForeignKey("OdaTipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelProject.Data.Models.Pansiyon", "Pansiyons")
                        .WithMany()
                        .HasForeignKey("Pansiyon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
