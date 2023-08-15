using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using exerciciosAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace exerciciosAPI.Context
{
    public class FichaContext : DbContext
    {

        public FichaContext(DbContextOptions options) : base(options)
        { }

        public DbSet<FichaModel> FichaModels { get; set; }
        public DbSet<DetalheModel> DetalheModels { get; set; }
        public DbSet<TelefoneModel> TelefoneModels { get; set; }

        // Declaração dos relacionamentos entre os modelos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<FichaModel>()
                        .HasMany(x => x.Detalhes)
                        .WithOne(y => y.Ficha)
                        .Metadata
                        .DeleteBehavior =  DeleteBehavior.Restrict;

            modelBuilder.Entity<FichaModel>()
                        .HasMany(x => x.Telefones)
                        .WithOne(y => y.Ficha)
                        .Metadata
                        .DeleteBehavior =  DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);       
        }

    }
}