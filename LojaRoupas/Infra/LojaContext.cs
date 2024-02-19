using LojaRoupas.Models;
using LojaRoupas.Models.Trade;
using Microsoft.EntityFrameworkCore;

namespace LojaRoupas.Infra
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {
        }
        public DbSet<RoupaPeca> Roupas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<VendaRoupa> Vendas{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(c => c.UserId);
            modelBuilder.Entity<Vendedor>().HasKey(c => c.UserId);
            modelBuilder.Entity<RoupaPeca>().HasKey(c => c.RoupaId);
            modelBuilder.Entity<VendaRoupa>().HasKey(c => c.TransacaoId);

            modelBuilder.Entity<VendaRoupa>()
                .HasOne(tr => tr.Vendedor)
                .WithMany(v => v.Transacoes)
                .HasForeignKey(tr => tr.VendedorId);

            modelBuilder.Entity<VendaRoupa>()
                .HasOne(tr => tr.Cliente)
                .WithMany(c => c.Transacoes)
                .HasForeignKey(tr => tr.ClienteId);

        }

    }
}
