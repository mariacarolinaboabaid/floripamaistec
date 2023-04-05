﻿using System;
using System.Reflection.Emit;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_002.Models.Configurations
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Peso_Nascimento)
            .HasPrecision(4,3);

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

