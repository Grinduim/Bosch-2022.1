using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace teste.DAO
{
    public class DAOContext : DbContext
    {
        public DbSet<TelefoneDAO> telefones { get; set; }
        public DbSet<PessoaDAO> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-S4T02R7\\SQLEXPRESS;" + "Initial Catalog = EstudandoEF; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TelefoneDAO>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.DD);
                entity.Property(p => p.Numero);
            });

            modelBuilder.Entity<PessoaDAO>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Nome);
                entity.Property(p => p.Idade);
                entity.HasOne(p => p.Telefone);
            });
        }
    }
}
