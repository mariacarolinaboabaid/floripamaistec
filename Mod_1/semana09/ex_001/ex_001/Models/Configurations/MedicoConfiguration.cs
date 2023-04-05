using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_001.Models.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(60);

            builder.Property(x => x.Crm)
                .HasMaxLength(60);

            builder.Property(x => x.Especialidade)
                .HasMaxLength(100);

            builder.ToTable("Medico");
        }
    }
}

