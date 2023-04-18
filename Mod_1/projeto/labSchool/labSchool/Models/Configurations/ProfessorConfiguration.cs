using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;

namespace labSchool.Models.Configurations
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            // INDICAÇÃO DA PK
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Codigo)
                .HasColumnOrder(1);

            // COLUNAS DA CLASSE PESSOA
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

            // COLUNAS DA CLASSE PROFESSOR
            builder.Property(x => x.Estado)
               .HasColumnName("Estado")
               .IsRequired()
               .HasColumnOrder(6);

            builder.Property(x => x.Experiencia)
                .HasColumnName("Experiência")
                .IsRequired()
                .HasColumnOrder(7);

            builder.Property(x => x.FormacaoAcademica)
                .HasColumnName("Formação_Acadêmica")
                .IsRequired()
                .HasColumnOrder(8);

            // NOME DA TABELA
            builder.ToTable("Professor");

            // ADIÇÃO DOS DADOS INICIAIS
            builder.HasData(new[]
            {
                new Professor() {Codigo = 1, Nome = "Walter White", Telefone = "14-22998-1882", DataNascimento = new DateTime(1982, 10, 30), Cpf = "40539019011", Estado = "ATIVO", Experiencia = "FULL_STACK", FormacaoAcademica = "MESTRADO"},
                new Professor() {Codigo = 2, Nome = "Jesse Pinkman", Telefone = "44-11111-1992" , DataNascimento = new DateTime(1997, 10, 30), Cpf = "96107295097", Estado = "ATIVO", Experiencia = "BACK_END",FormacaoAcademica = "GRADUAÇÃO_INCOMPLETA"},
                new Professor() {Codigo = 3, Nome = "Hank Schrader", Telefone = "44-11111-1002", DataNascimento = new DateTime(1984, 10, 30), Cpf = "70685977005", Estado = "ATIVO", Experiencia = "FULL_STACK",FormacaoAcademica = "MESTRADO"},
                new Professor() {Codigo = 4, Nome = "Gustavo Fring", Telefone = "44-11001-1002", DataNascimento = new DateTime(1977, 10, 30), Cpf = "57408927085", Estado = "INATIVO", Experiencia = "FRONT_END",FormacaoAcademica = "GRADUAÇÃO_COMPLETA"},
                new Professor() {Codigo = 5, Nome = "Saul Goodman", Telefone = "44-11998-1882", DataNascimento = new DateTime(1980, 10, 30), Cpf = "86940162062", Estado = "ATIVO", Experiencia = "FULL_STACK", FormacaoAcademica = "MESTRADO",}
            });
        }
    }
}





