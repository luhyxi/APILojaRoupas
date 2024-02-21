using LojaRoupas.Models;
using LojaRoupas.Models.Trade;
using LojaRoupas.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace LojaRoupas.Infra
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {
        }
        public DbSet<Roupa> Roupas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        
        public DbSet<Venda> Vendas{ get; set; }
        public DbSet<Troca> Trocas{ get; set; }
        public DbSet<Devolucao> Devolucoes{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.UserId);
            modelBuilder.Entity<Vendedor>()
                .HasKey(c => c.UserId);
            modelBuilder.Entity<Roupa>()
                .HasKey(c => c.RoupaId);
            modelBuilder.Entity<Venda>()
                .HasKey(c => c.VendaId);
            modelBuilder.Entity<Troca>()
                .HasKey(c => c.TrocaId);
            modelBuilder.Entity<Devolucao>()
                .HasKey(c => c.DevolucaoId);
        }

    }
}
