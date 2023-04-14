using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace labSchool.Models.Configurations
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
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

            // Colunas da classe Aluno
            builder.Property(x => x.SituacaoMatricula)
                .HasColumnName("Situação_Matrícula")
                .IsRequired()
                .HasColumnOrder(6);

            builder.Property(x => x.NotaProcessoSeletivo)
                .HasColumnName("Nota")
                .IsRequired()
                .HasColumnOrder(7);

            builder.Property(x => x.TotalAtendimentosPedagogicos)
                .HasColumnName("Atendimentos")
                .HasDefaultValue(0)
                .IsRequired()
                .HasColumnOrder(8);

            builder.ToTable("Aluno");
        }
    }
}

