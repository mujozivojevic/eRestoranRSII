﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eRestoran.WebApi.Database;

namespace eRestoran.WebApi.Migrations
{
    [DbContext(typeof(eRestoranContext))]
    [Migration("20191014205714_RezNaziv")]
    partial class RezNaziv
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eRestoran.WebApi.Database.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GradID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50);

                    b.HasKey("GradId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.JedinicaMjere", b =>
                {
                    b.Property<int>("JedinicaMjereId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.HasKey("JedinicaMjereId");

                    b.ToTable("JedinicaMjere");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Jelo", b =>
                {
                    b.Property<int>("JeloId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<int>("VrstaJelaId");

                    b.HasKey("JeloId");

                    b.HasIndex("VrstaJelaId");

                    b.ToTable("Jelo");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Klijent", b =>
                {
                    b.Property<int>("KlijentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KlijentId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojNarudzbi");

                    b.Property<DateTime>("DatumRegistracije");

                    b.HasKey("KlijentId");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("GradId")
                        .HasColumnName("GradID");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("KorisnikId");

                    b.HasIndex("GradId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Nabavka", b =>
                {
                    b.Property<int>("NabavkaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumNabavke");

                    b.Property<int>("UposlenikId");

                    b.Property<bool>("Zavrsena");

                    b.HasKey("NabavkaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Nabavka");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.NabavkaStavke", b =>
                {
                    b.Property<int>("DetaljiNarudzbeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<int>("Kolicina");

                    b.Property<int>("NabavkaId");

                    b.Property<int>("RobaId");

                    b.HasKey("DetaljiNarudzbeId");

                    b.HasIndex("NabavkaId");

                    b.HasIndex("RobaId");

                    b.ToTable("NabavkaStavke");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumNarudžbe");

                    b.Property<int>("KlijentId");

                    b.Property<bool>("Zavrsena");

                    b.HasKey("NarudzbaId");

                    b.HasIndex("KlijentId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.NarudzbaStavke", b =>
                {
                    b.Property<int>("NarudzbaStavkeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<int>("JeloId");

                    b.Property<int>("Kolicina");

                    b.Property<int>("NarudzbaId");

                    b.HasKey("NarudzbaStavkeId");

                    b.HasIndex("JeloId");

                    b.HasIndex("NarudzbaId");

                    b.ToTable("NarudzbaStavke");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Obavijest", b =>
                {
                    b.Property<int>("ObavijestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Naziv");

                    b.Property<string>("Sadrzaj");

                    b.Property<int>("UposlenikId");

                    b.HasKey("ObavijestId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumEvidencije");

                    b.Property<DateTime>("DatumRezervacije");

                    b.Property<int>("KlijentId");

                    b.Property<string>("Naziv");

                    b.HasKey("RezervacijaId");

                    b.HasIndex("KlijentId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.RezervacijaStavke", b =>
                {
                    b.Property<int>("RezervacijaStavkeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RezervacijaId");

                    b.Property<int>("StolId");

                    b.HasKey("RezervacijaStavkeId");

                    b.HasIndex("RezervacijaId");

                    b.HasIndex("StolId");

                    b.ToTable("RezervacijaStavke");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Roba", b =>
                {
                    b.Property<int>("RobaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<int>("JedinicaMjereId");

                    b.Property<int>("KategorijaId");

                    b.Property<string>("Naziv");

                    b.Property<string>("Sifra");

                    b.Property<int>("Stanje");

                    b.HasKey("RobaId");

                    b.HasIndex("JedinicaMjereId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Roba");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Stol", b =>
                {
                    b.Property<int>("StolId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojMjesta");

                    b.HasKey("StolId");

                    b.ToTable("Stol");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Uposlenik", b =>
                {
                    b.Property<int>("UposlenikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UposlenikID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<DateTime>("DatumZaposljavanja")
                        .HasColumnType("date");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnName("JMBG")
                        .HasMaxLength(50);

                    b.Property<bool>("Status");

                    b.Property<int>("VrstaId")
                        .HasColumnName("VrstaID");

                    b.HasKey("UposlenikId");

                    b.HasIndex("VrstaId");

                    b.ToTable("Uposlenik");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.VrstaJela", b =>
                {
                    b.Property<int>("VrstaJelaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("VrstaJelaId");

                    b.ToTable("VrstaJela");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.VrstaUposlenika", b =>
                {
                    b.Property<int>("VrstaUposlenikaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("VrstaUposlenikaId");

                    b.ToTable("VrstaUposlenika");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Jelo", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.VrstaJela", "VrstaJela")
                        .WithMany()
                        .HasForeignKey("VrstaJelaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Klijent", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Korisnik", "KlijentNavigation")
                        .WithOne("Klijent")
                        .HasForeignKey("eRestoran.WebApi.Database.Klijent", "KlijentId")
                        .HasConstraintName("FK_Klijent_Korisnik2");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Korisnik", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Grad", "Grad")
                        .WithMany("Korisnik")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Korisnik2_Grad");
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Nabavka", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.NabavkaStavke", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Nabavka", "Nabavka")
                        .WithMany()
                        .HasForeignKey("NabavkaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eRestoran.WebApi.Database.Roba", "Roba")
                        .WithMany()
                        .HasForeignKey("RobaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Narudzba", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.NarudzbaStavke", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Jelo", "Jelo")
                        .WithMany()
                        .HasForeignKey("JeloId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eRestoran.WebApi.Database.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Obavijest", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Uposlenik", "Uposlenik")
                        .WithMany()
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Rezervacija", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.RezervacijaStavke", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eRestoran.WebApi.Database.Stol", "Stol")
                        .WithMany()
                        .HasForeignKey("StolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Roba", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.JedinicaMjere", "JedinicaMjere")
                        .WithMany()
                        .HasForeignKey("JedinicaMjereId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eRestoran.WebApi.Database.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eRestoran.WebApi.Database.Uposlenik", b =>
                {
                    b.HasOne("eRestoran.WebApi.Database.Korisnik", "UposlenikNavigation")
                        .WithOne("Uposlenik")
                        .HasForeignKey("eRestoran.WebApi.Database.Uposlenik", "UposlenikId")
                        .HasConstraintName("FK_Uposlenik_Korisnik2");

                    b.HasOne("eRestoran.WebApi.Database.VrstaUposlenika", "Vrsta")
                        .WithMany("Uposlenik")
                        .HasForeignKey("VrstaId")
                        .HasConstraintName("FK_Uposlenik_VrstaUposlenika");
                });
#pragma warning restore 612, 618
        }
    }
}
