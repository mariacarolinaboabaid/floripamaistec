using System;
using ex_001.Models;
using Microsoft.EntityFrameworkCore;

namespace ex_001.Context
{
	public class BercarioContext : DbContext
	{
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

        public BercarioContext(DbContextOptions<BercarioContext> options) : base(options)
        {

        }
    }
}

