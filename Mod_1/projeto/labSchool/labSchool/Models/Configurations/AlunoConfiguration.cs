using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace labSchool.Models.Configurations
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            // INDICAÇÃO DA PK
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Codigo)
                .HasColumnOrder(1);

            // COLUNAS CLASSE PESSOA
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

            // COLUNAS DA CLASSE ALUNO
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

            // NOME DA TABELA
            builder.ToTable("Aluno");

            // ADIÇÃO DOS DADOS INICIAIS
            builder.HasData(new[]
            {
                new Aluno() {Codigo = 1, Nome = "Bart Simpson", Telefone = "11-11111-1212", DataNascimento = new DateTime(2014, 10, 29), Cpf = "11839750073" , SituacaoMatricula = "IRREGULAR", NotaProcessoSeletivo = 3.5f , TotalAtendimentosPedagogicos = 0 },
                new Aluno() {Codigo = 2, Nome = "Lisa Simpson", Telefone = "11-22222-2222", DataNascimento = new DateTime(2012, 10, 29), Cpf = "17158947076", SituacaoMatricula = "ATIVO", NotaProcessoSeletivo = 10, TotalAtendimentosPedagogicos = 0 },
                new Aluno() {Codigo = 3, Nome = "Meggie Simpson", Telefone = "12-20002-2200" , DataNascimento = new DateTime(2019, 10, 29), Cpf = "63701210020", SituacaoMatricula = "ATIVO", NotaProcessoSeletivo = 9, TotalAtendimentosPedagogicos = 0 },
                new Aluno() {Codigo = 4, Nome = "Milhouse Van Houten", Telefone = "11-33333-2222", DataNascimento = new DateTime(2014, 10, 29), Cpf = "30119137062", SituacaoMatricula = "ATIVO", NotaProcessoSeletivo = 8, TotalAtendimentosPedagogicos = 0 },
                new Aluno() {Codigo = 5, Nome = "Nelson Muntz", Telefone = "11-44333-4444", DataNascimento = new DateTime(2007, 10, 29), Cpf = "95704094015", SituacaoMatricula = "INATIVO", NotaProcessoSeletivo = 2, TotalAtendimentosPedagogicos = 0 },
            });
        }
    }
}


