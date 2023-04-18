using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;

namespace labSchool.Models.Configurations
{
    public class PedagogoConfiguration : IEntityTypeConfiguration<Pedagogo>
    {
        public void Configure(EntityTypeBuilder<Pedagogo> builder)
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

            // COLUNA DA CLASSE PEDAGOGO
            builder.Property(x => x.TotalAtendimentosPedagogicos)
                .HasColumnName("Atendimentos")
                .HasDefaultValue(0)
                .IsRequired()
                .HasColumnOrder(6);

            // NOME DA TABELA
            builder.ToTable("Pedagogo");

            // ADIÇÃO DOS DADOS INICIAIS
            builder.HasData(new[]
            {
                new Pedagogo() {Codigo = 1, Nome = "John Snow", Telefone = "11-67333-4454", DataNascimento = new DateTime(2000, 10, 30), Cpf = "62316840086",TotalAtendimentosPedagogicos = 0 },
                new Pedagogo() {Codigo = 2, Nome = "Sansa Stark", Telefone =  "22-22333-4454", DataNascimento = new DateTime(2004, 10, 30), Cpf = "49850253053", TotalAtendimentosPedagogicos = 0 },
                new Pedagogo() {Codigo = 3, Nome = "Tyrion Lannister", Telefone = "33-77333-4454" , DataNascimento = new DateTime(1990, 10, 30), Cpf = "39125106015", TotalAtendimentosPedagogicos = 0 },
                new Pedagogo() {Codigo = 4, Nome = "Sandor Clegane", Telefone = "11-33333-2222", DataNascimento = new DateTime(1995, 10, 30), Cpf = "89089606009", TotalAtendimentosPedagogicos = 0 },
            });
        }
    }
}



