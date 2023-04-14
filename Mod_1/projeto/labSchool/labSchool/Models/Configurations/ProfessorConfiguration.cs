using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace labSchool.Models.Configurations
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Codigo)
                .HasColumnOrder(1);

            // Colunas da classe Pessoa
            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasColumnOrder(2);

            builder.Property(x => x.Telefone)
                .HasColumnName("Telefone")
                .IsRequired()
                .HasColumnOrder(3);

            builder.Property(x => x.DataNascimento)
                .HasColumnName("Data_Nascimento")
                .IsRequired()
                .HasColumnOrder(4);

            builder.Property(x => x.Cpf)
                .HasColumnName("CPF")
                .IsRequired()
                .HasColumnOrder(5);
            builder.HasIndex(x => x.Cpf)
                    .IsUnique();

            // Colunas da classe Professor
            builder.Property(x => x.FormacaoAcademica)
                .HasColumnName("Formação_Acadêmica")
                .IsRequired()
                .HasColumnOrder(6);

            builder.Property(x => x.Experiencia)
                .HasColumnName("Experiência")
                .IsRequired()
                .HasColumnOrder(7);

            builder.Property(x => x.Estado)
                .HasColumnName("Estado")
                .IsRequired()
                .HasColumnOrder(8);

            builder.ToTable("Professor");
        }
    }
}

