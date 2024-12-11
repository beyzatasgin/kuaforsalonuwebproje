﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kuaforsalonu.Models;

#nullable disable

namespace kuaforsalonu.Migrations
{
    [DbContext(typeof(Kuaforsalonu))]
    [Migration("20241211103117_Salonlar")]
    partial class Salonlar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kuaforsalonu.Models.Calisan", b =>
                {
                    b.Property<int>("CalisanNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalisanNo"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("SalonId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Uzmanlik")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CalisanNo");

                    b.HasIndex("SalonId");

                    b.ToTable("Çalışanlar", (string)null);
                });

            modelBuilder.Entity("kuaforsalonu.Models.Musteri", b =>
                {
                    b.Property<int>("MusteriNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusteriNo"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("YetkiNo")
                        .HasColumnType("int");

                    b.Property<int>("YetkiNo1")
                        .HasColumnType("int");

                    b.HasKey("MusteriNo");

                    b.HasIndex("YetkiNo1");

                    b.ToTable("Müşteriler", (string)null);
                });

            modelBuilder.Entity("kuaforsalonu.Models.Randevu", b =>
                {
                    b.Property<int>("RandevuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RandevuID"));

                    b.Property<int>("CalisanNo")
                        .HasColumnType("int");

                    b.Property<int>("MusteriNo")
                        .HasColumnType("int");

                    b.Property<int>("SaatID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("date");

                    b.HasKey("RandevuID");

                    b.HasIndex("CalisanNo");

                    b.HasIndex("MusteriNo");

                    b.HasIndex("SaatID");

                    b.ToTable("Randevular", (string)null);
                });

            modelBuilder.Entity("kuaforsalonu.Models.Saat", b =>
                {
                    b.Property<int>("SaatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaatID"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SaatID");

                    b.ToTable("Saat", (string)null);
                });

            modelBuilder.Entity("kuaforsalonu.Models.Salon", b =>
                {
                    b.Property<int>("SalonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalonId"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalismaSaatleri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalonId");

                    b.ToTable("Salonlar", (string)null);
                });

            modelBuilder.Entity("kuaforsalonu.Models.Yetki", b =>
                {
                    b.Property<int>("YetkiNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YetkiNo"));

                    b.Property<string>("YetkiAdı")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("YetkiNo");

                    b.ToTable("Yetki", (string)null);
                });

            modelBuilder.Entity("kuaforsalonu.Models.Calisan", b =>
                {
                    b.HasOne("kuaforsalonu.Models.Salon", null)
                        .WithMany("Calisanlar")
                        .HasForeignKey("SalonId");
                });

            modelBuilder.Entity("kuaforsalonu.Models.Musteri", b =>
                {
                    b.HasOne("kuaforsalonu.Models.Yetki", "Yetki")
                        .WithMany("Musteris")
                        .HasForeignKey("YetkiNo1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yetki");
                });

            modelBuilder.Entity("kuaforsalonu.Models.Randevu", b =>
                {
                    b.HasOne("kuaforsalonu.Models.Calisan", "Calisan")
                        .WithMany("Randevus")
                        .HasForeignKey("CalisanNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kuaforsalonu.Models.Musteri", "Musteri")
                        .WithMany("Randevular")
                        .HasForeignKey("MusteriNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kuaforsalonu.Models.Saat", "Saat")
                        .WithMany("Randevus")
                        .HasForeignKey("SaatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Musteri");

                    b.Navigation("Saat");
                });

            modelBuilder.Entity("kuaforsalonu.Models.Calisan", b =>
                {
                    b.Navigation("Randevus");
                });

            modelBuilder.Entity("kuaforsalonu.Models.Musteri", b =>
                {
                    b.Navigation("Randevular");
                });

            modelBuilder.Entity("kuaforsalonu.Models.Saat", b =>
                {
                    b.Navigation("Randevus");
                });

            modelBuilder.Entity("kuaforsalonu.Models.Salon", b =>
                {
                    b.Navigation("Calisanlar");
                });

            modelBuilder.Entity("kuaforsalonu.Models.Yetki", b =>
                {
                    b.Navigation("Musteris");
                });
#pragma warning restore 612, 618
        }
    }
}
