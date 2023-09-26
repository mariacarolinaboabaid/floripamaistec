using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using loja.Models;

namespace loja.Context
{
    public class LojaContext : DbContext
    {
        // Construtor
        public LojaContext(DbContextOptions options) : base(options){}

        // Tabelas
        public DbSet<VendaModel> Vendas { get; set; }
        public DbSet<ProdutoModel> Produtos  { get; set; }
        public DbSet<ClienteModel> Clientes  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendaModel>()
				.HasOne(x => x.Produto)
				.WithMany(y => y.Vendas)
				.HasForeignKey(x => x.ProdutoId);

                modelBuilder.Entity<VendaModel>()
				.HasOne(x => x.Cliente)
				.WithMany(y => y.Vendas)
				.HasForeignKey(x => x.ClienteId);

                 base.OnModelCreating(modelBuilder);
        }
    }
}