﻿// <auto-generated />
using System;
using BankaProjekat.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankaProjekat.Migrations
{
    [DbContext(typeof(BankaDbContext))]
    [Migration("20230823101602_Nova Migracija")]
    partial class NovaMigracija
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BankaProjekat.Models.Banka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Kontakt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pib")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Banka");
                });

            modelBuilder.Entity("BankaProjekat.Models.Filijala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("BrojPultova")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankaId");

                    b.ToTable("Filijalas");
                });

            modelBuilder.Entity("BankaProjekat.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaticniBroj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Korisniks");
                });

            modelBuilder.Entity("BankaProjekat.Models.Usluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilijalaId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpisUsluge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provizija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilijalaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Uslugas");
                });

            modelBuilder.Entity("BankaProjekat.Models.Filijala", b =>
                {
                    b.HasOne("BankaProjekat.Models.Banka", "Banka")
                        .WithMany("Filijals")
                        .HasForeignKey("BankaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Banka");
                });

            modelBuilder.Entity("BankaProjekat.Models.Usluga", b =>
                {
                    b.HasOne("BankaProjekat.Models.Filijala", "Filijala")
                        .WithMany("Uslugas")
                        .HasForeignKey("FilijalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankaProjekat.Models.Korisnik", "Korisnik")
                        .WithMany("Uslugas")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filijala");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("BankaProjekat.Models.Banka", b =>
                {
                    b.Navigation("Filijals");
                });

            modelBuilder.Entity("BankaProjekat.Models.Filijala", b =>
                {
                    b.Navigation("Uslugas");
                });

            modelBuilder.Entity("BankaProjekat.Models.Korisnik", b =>
                {
                    b.Navigation("Uslugas");
                });
#pragma warning restore 612, 618
        }
    }
}
