using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_002.Models.Configurations
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Medico)
                .WithMany(p => p.Partos)
                .HasForeignKey(x => x.Medico_Id)
                .HasConstraintName("FK_MEDICO_PARTO");

            builder.ToTable("Parto");
        }
    }
}

