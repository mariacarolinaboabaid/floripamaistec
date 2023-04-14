using System;
using labSchool.Models;
using labSchool.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace labSchool.Context
{
	public class LabSchoolContext : DbContext
	{
		// Tabelas
		public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Pedagogo> Pedagogos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        // Adicionando as configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new PedagogoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
        }

        // Construtor
        public LabSchoolContext(DbContextOptions<LabSchoolContext> options) : base(options)
        {

        }
    }
}

