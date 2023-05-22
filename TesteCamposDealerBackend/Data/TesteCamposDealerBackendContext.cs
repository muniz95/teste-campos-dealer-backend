using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using TesteCamposDealerBackend.Models;
using TesteCamposDealerBackend.Utils;

namespace TesteCamposDealerBackend.Data
{
    public partial class TesteCamposDealerBackendContext : DbContext
    {
        public TesteCamposDealerBackendContext (DbContextOptions<TesteCamposDealerBackendContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Cliente> Clientes { get; set; } = default!;
        public DbSet<Models.Produto> Produtos { get; set; } = default!;
        public DbSet<Models.Venda> Vendas { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var client = new HTTPFetch();

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clientes");

                entity.HasKey(e => e.idCliente);

                entity.Property(e => e.nmCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nmCliente");

                entity.Property(e => e.Cidade)
                    .HasColumnType("Text")
                    .IsUnicode(false)
                    .HasColumnName("cidade");
            });
            modelBuilder.Entity<Cliente>().HasData(client.ObterClientes());

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("Produtos");

                entity.HasKey(e => e.idProduto);

                entity.Property(e => e.dscProduto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dscProduto");

                entity.Property(e => e.vlrUnitario)
                    .HasColumnName("vlrUnitario");
            });
            modelBuilder.Entity<Produto>().HasData(client.ObterProdutos());

            modelBuilder.Entity<Venda>(entity =>
            {
                entity.ToTable("Vendas");

                entity.HasKey(e => e.idVenda); 

                entity.HasOne(e => e.Cliente)
                    .WithMany(e => e.vendas)
                    .IsRequired(false)
                    .HasForeignKey(e => e.idCliente);

                entity.HasOne(e => e.Produto)
                    .WithMany(e => e.vendas)
                    .IsRequired(false)
                    .HasForeignKey(e => e.idProduto);

                entity.Property(e => e.qtdVenda)
                    .HasColumnName("qtdVenda");

                entity.Property(e => e.vlrUnitarioVenda)
                    .HasColumnName("vlrUnitarioVenda");

                entity.Property(e => e.dthVenda)
                    .HasColumnName("dthVenda");

                entity.Property(e => e.vlrTotalVenda)
                    .HasColumnName("vlrTotalVenda");
            });
            modelBuilder.Entity<Venda>().HasData(client.ObterVendas());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
