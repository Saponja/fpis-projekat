﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fpis_projekat.Domain;

namespace fpis_projekat.Migrations
{
    [DbContext(typeof(FpisContext))]
    partial class FpisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrevoznoSredstvoStavkaPorudzbenice", b =>
                {
                    b.Property<int>("PrevoznaSredstvaPrevoznoSredstvoId")
                        .HasColumnType("int");

                    b.Property<int>("StavkePorudzbeniceStavkaPorudzbeniceId")
                        .HasColumnType("int");

                    b.Property<int>("StavkePorudzbenicePorudzbenicaId")
                        .HasColumnType("int");

                    b.HasKey("PrevoznaSredstvaPrevoznoSredstvoId", "StavkePorudzbeniceStavkaPorudzbeniceId", "StavkePorudzbenicePorudzbenicaId");

                    b.HasIndex("StavkePorudzbeniceStavkaPorudzbeniceId", "StavkePorudzbenicePorudzbenicaId");

                    b.ToTable("Prevozi");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Cenovnik", b =>
                {
                    b.Property<int>("CenovnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("DrzavaId")
                        .HasColumnType("int");

                    b.Property<int>("RadnikId")
                        .HasColumnType("int");

                    b.HasKey("CenovnikId");

                    b.HasIndex("DrzavaId");

                    b.HasIndex("RadnikId");

                    b.ToTable("Cenovnici");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Drzava", b =>
                {
                    b.Property<int>("DrzavaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivDrzave")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaId");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<int>("DrzavaId")
                        .HasColumnType("int");

                    b.Property<string>("NazivGrada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradId", "DrzavaId");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Karatkeristika", b =>
                {
                    b.Property<int>("KarakteristikaId")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<string>("NazivKarakteristike")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Vrednost")
                        .HasColumnType("float");

                    b.HasKey("KarakteristikaId", "ProizvodId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Karatkeristike");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Kupac", b =>
                {
                    b.Property<int>("KupacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaId")
                        .HasColumnType("int");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("NazivKupca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UlicaBroj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KupacId");

                    b.HasIndex("DrzavaId");

                    b.HasIndex("GradId", "DrzavaId");

                    b.ToTable("Kupci");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Otpremnica", b =>
                {
                    b.Property<int>("OtpremnicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("RadnikId")
                        .HasColumnType("int");

                    b.HasKey("OtpremnicaId");

                    b.HasIndex("RadnikId");

                    b.ToTable("Otpremnice");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Porudzbenica", b =>
                {
                    b.Property<int>("PorudzbenicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PIBKupuje")
                        .HasColumnType("int");

                    b.Property<int>("PIBPlaca")
                        .HasColumnType("int");

                    b.Property<int>("PIBPrima")
                        .HasColumnType("int");

                    b.Property<int>("RadnikId")
                        .HasColumnType("int");

                    b.HasKey("PorudzbenicaId");

                    b.HasIndex("PIBKupuje");

                    b.HasIndex("PIBPlaca");

                    b.HasIndex("PIBPrima");

                    b.HasIndex("RadnikId");

                    b.ToTable("Porudzbenice");
                });

            modelBuilder.Entity("fpis_projekat.Domain.PrevoznoSredstvo", b =>
                {
                    b.Property<int>("PrevoznoSredstvoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivSredstva")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrevoznoSredstvoId");

                    b.ToTable("PrevoznaSredstva");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Proizvod", b =>
                {
                    b.Property<int>("ProizvodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivModela")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProizvodId");

                    b.ToTable("Proizvodi");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Radnik", b =>
                {
                    b.Property<int>("RadnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RadnikId");

                    b.ToTable("Radnici");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Reklamacija", b =>
                {
                    b.Property<int>("ReklamacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.HasKey("ReklamacijaId");

                    b.ToTable("Reklamacije");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaCenovnika", b =>
                {
                    b.Property<int>("StavkaCenovnikaId")
                        .HasColumnType("int");

                    b.Property<int>("CenovnikId")
                        .HasColumnType("int");

                    b.Property<double>("CenaBezPDV")
                        .HasColumnType("float");

                    b.Property<double>("CenaSaPDV")
                        .HasColumnType("float");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("StavkaCenovnikaId", "CenovnikId");

                    b.HasIndex("CenovnikId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("StavkeCenovnika");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaOtpremnice", b =>
                {
                    b.Property<int>("StavkaOtpremniceId")
                        .HasColumnType("int");

                    b.Property<int>("OtpremnicaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PorudzbenicaId")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("StavkaOtpremniceId", "OtpremnicaId");

                    b.HasIndex("OtpremnicaId");

                    b.HasIndex("PorudzbenicaId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("StavkeOtpremnice");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaPorudzbenice", b =>
                {
                    b.Property<int>("StavkaPorudzbeniceId")
                        .HasColumnType("int");

                    b.Property<int>("PorudzbenicaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumIsporuke")
                        .HasColumnType("datetime2");

                    b.Property<double>("Kolicina")
                        .HasColumnType("float");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("StavkaPorudzbeniceId", "PorudzbenicaId");

                    b.HasIndex("PorudzbenicaId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("StavkePorudzbenice");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaReklamacije", b =>
                {
                    b.Property<int>("StavkaReklamacijeId")
                        .HasColumnType("int");

                    b.Property<int>("ReklamacijaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int");

                    b.HasKey("StavkaReklamacijeId", "ReklamacijaId");

                    b.HasIndex("ProizvodId");

                    b.HasIndex("ReklamacijaId");

                    b.ToTable("StavkeReklamacije");
                });

            modelBuilder.Entity("PrevoznoSredstvoStavkaPorudzbenice", b =>
                {
                    b.HasOne("fpis_projekat.Domain.PrevoznoSredstvo", null)
                        .WithMany()
                        .HasForeignKey("PrevoznaSredstvaPrevoznoSredstvoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.StavkaPorudzbenice", null)
                        .WithMany()
                        .HasForeignKey("StavkePorudzbeniceStavkaPorudzbeniceId", "StavkePorudzbenicePorudzbenicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fpis_projekat.Domain.Cenovnik", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Drzava", "Drzava")
                        .WithMany("Cenovnici")
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Radnik", "Radnik")
                        .WithMany("Cenovnici")
                        .HasForeignKey("RadnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Grad", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Drzava", "Drzava")
                        .WithMany("Gradovi")
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Karatkeristika", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Proizvod", "Proizvod")
                        .WithMany("Karatkeristike")
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Kupac", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Grad", "Grad")
                        .WithMany("Kupci")
                        .HasForeignKey("GradId", "DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Otpremnica", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Radnik", "Radnik")
                        .WithMany("Otpremnice")
                        .HasForeignKey("RadnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Porudzbenica", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Kupac", "Kupuje")
                        .WithMany("Kupovanja")
                        .HasForeignKey("PIBKupuje")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Kupac", "Placa")
                        .WithMany("Placanja")
                        .HasForeignKey("PIBPlaca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Kupac", "Prima")
                        .WithMany("Primanja")
                        .HasForeignKey("PIBPrima")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Radnik", "Radnik")
                        .WithMany("Porudzbenice")
                        .HasForeignKey("RadnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupuje");

                    b.Navigation("Placa");

                    b.Navigation("Prima");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaCenovnika", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Cenovnik", "Cenovnik")
                        .WithMany("StavkeCenovnika")
                        .HasForeignKey("CenovnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Proizvod", "Proizvod")
                        .WithMany("StavkeCenovnika")
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cenovnik");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaOtpremnice", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Otpremnica", "Otpremnica")
                        .WithMany("StavkeOtpremnice")
                        .HasForeignKey("OtpremnicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Porudzbenica", "Porudzbenica")
                        .WithMany("StavkeOtpremnice")
                        .HasForeignKey("PorudzbenicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Proizvod", "Proizvod")
                        .WithMany("StavkeOtpremnice")
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Otpremnica");

                    b.Navigation("Porudzbenica");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaPorudzbenice", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Porudzbenica", "Porudzbenica")
                        .WithMany("StavkePorudzbenice")
                        .HasForeignKey("PorudzbenicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Proizvod", "Proizvod")
                        .WithMany("StavkePorudzbenice")
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Porudzbenica");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("fpis_projekat.Domain.StavkaReklamacije", b =>
                {
                    b.HasOne("fpis_projekat.Domain.Proizvod", "Proizvod")
                        .WithMany("StavkeReklamacije")
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fpis_projekat.Domain.Reklamacija", "Reklamacija")
                        .WithMany("StavkeReklamacije")
                        .HasForeignKey("ReklamacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proizvod");

                    b.Navigation("Reklamacija");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Cenovnik", b =>
                {
                    b.Navigation("StavkeCenovnika");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Drzava", b =>
                {
                    b.Navigation("Cenovnici");

                    b.Navigation("Gradovi");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Grad", b =>
                {
                    b.Navigation("Kupci");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Kupac", b =>
                {
                    b.Navigation("Kupovanja");

                    b.Navigation("Placanja");

                    b.Navigation("Primanja");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Otpremnica", b =>
                {
                    b.Navigation("StavkeOtpremnice");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Porudzbenica", b =>
                {
                    b.Navigation("StavkeOtpremnice");

                    b.Navigation("StavkePorudzbenice");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Proizvod", b =>
                {
                    b.Navigation("Karatkeristike");

                    b.Navigation("StavkeCenovnika");

                    b.Navigation("StavkeOtpremnice");

                    b.Navigation("StavkePorudzbenice");

                    b.Navigation("StavkeReklamacije");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Radnik", b =>
                {
                    b.Navigation("Cenovnici");

                    b.Navigation("Otpremnice");

                    b.Navigation("Porudzbenice");
                });

            modelBuilder.Entity("fpis_projekat.Domain.Reklamacija", b =>
                {
                    b.Navigation("StavkeReklamacije");
                });
#pragma warning restore 612, 618
        }
    }
}