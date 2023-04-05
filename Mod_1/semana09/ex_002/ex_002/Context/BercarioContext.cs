using System;
using ex_002.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ex_002.Models.Configurations;

namespace ex_002.Context
{
    public class BercarioContext : DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
            modelBuilder.ApplyConfiguration(new MaeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new PartoConfiguration());
            
        }

        public BercarioContext(DbContextOptions<BercarioContext> options) : base(options)
        {

        }
    }
}