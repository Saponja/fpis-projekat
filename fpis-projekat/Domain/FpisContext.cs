using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpis_projekat.Domain
{
    public class FpisContext : DbContext
    {

        public DbSet<Radnik> Radnici { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Proizvod> Proizvodi { get; set; }
        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<Porudzbenica> Porudzbenice { get; set; }
        public DbSet<StavkaPorudzbenice> StavkePorudzbenice { get; set; }
        public DbSet<Otpremnica> Otpremnice { get; set; }
        public DbSet<StavkaOtpremnice> StavkeOtpremnice { get; set; }
        public DbSet<Reklamacija> Reklamacije { get; set; }
        public DbSet<StavkaReklamacije> StavkeReklamacije { get; set; }
        public DbSet<Cenovnik> Cenovnici { get; set; }
        public DbSet<StavkaCenovnika> StavkeCenovnika { get; set; }
        public DbSet<Karatkeristika> Karatkeristike { get; set; }
        public DbSet<PrevoznoSredstvo> PrevoznaSredstva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=fpis-baza;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Porudzbenica>(por =>
            {
                por.HasOne(p => p.Kupuje)
                .WithMany(k => k.Kupovanja)
                .HasForeignKey(p => p.PIBKupuje);
                por.HasOne(p => p.Placa)
                .WithMany(k => k.Placanja)
                .HasForeignKey(p => p.PIBPlaca);
                por.HasOne(p => p.Prima)
                .WithMany(k => k.Primanja)
                .HasForeignKey(p => p.PIBPrima);
                por.HasMany(p => p.StavkeOtpremnice).WithOne(s => s.Porudzbenica).HasForeignKey(s => s.PorudzbenicaId);
                por.HasMany(p => p.StavkePorudzbenice).WithOne(s => s.Porudzbenica).HasForeignKey(s => s.PorudzbenicaId);
            });

            modelBuilder.Entity<StavkaPorudzbenice>(sp =>
            {
                sp.HasKey(s => new { s.StavkaPorudzbeniceId, s.PorudzbenicaId });
                sp.HasMany(s => s.PrevoznaSredstva).WithMany(p => p.StavkePorudzbenice).UsingEntity(j => j.ToTable("Prevozi"));
            });

            modelBuilder.Entity<Grad>(gr =>
            {
                gr.HasKey(g => new { g.GradId, g.DrzavaId });
                gr.HasOne(g => g.Drzava).WithMany(d => d.Gradovi).HasForeignKey(g => g.DrzavaId);
            });

            modelBuilder.Entity<Kupac>(kup =>
            {
                kup.HasOne(k => k.Grad).WithMany(g => g.Kupci).HasForeignKey(ku => new { ku.GradId, ku.DrzavaId });
            });

            modelBuilder.Entity<Drzava>(dr =>
            {
                dr.HasMany(d => d.Cenovnici).WithOne(c => c.Drzava).HasForeignKey(ce => ce.DrzavaId);
            });

            modelBuilder.Entity<StavkaCenovnika>(sc =>
            {
                sc.HasKey(s => new { s.StavkaCenovnikaId, s.CenovnikId });
                sc.HasOne(s => s.Cenovnik).WithMany(c => c.StavkeCenovnika).HasForeignKey(st => st.CenovnikId);
            });
            modelBuilder.Entity<Radnik>(rad =>
            {
                rad.HasMany(r => r.Porudzbenice).WithOne(p => p.Radnik).HasForeignKey(pr => pr.RadnikId);
                rad.HasMany(r => r.Otpremnice).WithOne(o => o.Radnik).HasForeignKey(ot => ot.RadnikId);
                rad.HasMany(r => r.Cenovnici).WithOne(c => c.Radnik).HasForeignKey(ce => ce.RadnikId);
            });

            modelBuilder.Entity<Proizvod>(pro =>
            {
                pro.HasMany(p => p.StavkePorudzbenice).WithOne(s => s.Proizvod).HasForeignKey(st => st.ProizvodId);
                pro.HasMany(p => p.StavkeOtpremnice).WithOne(s => s.Proizvod).HasForeignKey(st => st.ProizvodId);
                pro.HasMany(p => p.StavkeCenovnika).WithOne(s => s.Proizvod).HasForeignKey(st => st.ProizvodId);
                pro.HasMany(p => p.StavkeReklamacije).WithOne(s => s.Proizvod).HasForeignKey(st => st.ProizvodId);

            });

            modelBuilder.Entity<Karatkeristika>(kar =>
            {
                kar.HasKey(k => new { k.KarakteristikaId, k.ProizvodId });
                kar.HasOne(k => k.Proizvod).WithMany(p => p.Karatkeristike).HasForeignKey(ka => ka.ProizvodId);
            });

            modelBuilder.Entity<StavkaReklamacije>(st =>
            {
                st.HasKey(s => new { s.StavkaReklamacijeId, s.ReklamacijaId });
                st.HasOne(s => s.Reklamacija).WithMany(r => r.StavkeReklamacije).HasForeignKey(sr => sr.ReklamacijaId);
            });

            modelBuilder.Entity<StavkaOtpremnice>(st =>
            {
                st.HasKey(s => new { s.StavkaOtpremniceId, s.OtpremnicaId });
                st.HasOne(s => s.Otpremnica).WithMany(o => o.StavkeOtpremnice).HasForeignKey(st => st.OtpremnicaId);
            });

        }
    }
}
