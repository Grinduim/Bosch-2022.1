using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DAO
{
    public class DAOContext : DbContext
    {

        public DbSet<Arma> Armas { get; set; }
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<IdentidadeSecretas> IdentidadesSecretas { get; set; }
        public DbSet<HeroisBatalhas> HeroisBatalhas { get; set; }
        public DbSet<Batalhas> Batalhas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source = JVLPC0497; Initial Catalog = HeroiApp; Integrated Security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Arma>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Nome);
            });

            modelBuilder.Entity<Heroi>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Nome);
                e.HasMany(e => e.Armas);
                e.HasMany(e => e.Batalhas);
            });

            modelBuilder.Entity<IdentidadeSecretas>(e =>
            {
                e.HasKey(e => e.ID);
                e.Property(e => e.NomeReal);
                e.HasOne(e => e.Heroi);
            });

            modelBuilder.Entity<Batalhas>(e =>
            {
                e.HasKey(e => e.ID);
                e.Property(e => e.Nome);
                e.Property(e => e.Descricao);
                e.Property(e => e.DtFim);
                e.Property(e => e.DtInicio);
                //e.HasOne(e => e.HeroisBatalhas);
            });

            modelBuilder.Entity<HeroisBatalhas>(e =>
            {
                e.HasKey(e => e.ID);
                e.HasOne(e => e.Batalhas);
                e.HasOne(e => e.Heroi);
            });
        }
    }
}
