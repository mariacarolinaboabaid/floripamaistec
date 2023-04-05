using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_001.Models.Configurations
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Mae)
                .WithMany(m => m.Bebes)
                .HasForeignKey(x => x.Mae_Id)
                .HasConstraintName("FK_MAE_BEBE");

            builder.HasOne(x => x.Parto)
                .WithMany(p => p.Bebes)
                .HasForeignKey(x => x.Parto_Id)
                .HasConstraintName("FK_PARTO_BEBE");

            builder.ToTable("Bebe");
        }
    }
}

