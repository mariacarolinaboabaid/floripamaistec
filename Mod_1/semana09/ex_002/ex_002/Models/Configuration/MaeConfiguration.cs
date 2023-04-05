using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_002.Models.Configurations
{
    public class MaeConfiguration : IEntityTypeConfiguration<Mae>
    {
        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(60);

            builder.Property(x => x.Endereco)
                .HasMaxLength(300);

            builder.Property(x => x.Telefone)
                .HasMaxLength(20);

            builder.ToTable("Mae");
        }
    }
}
