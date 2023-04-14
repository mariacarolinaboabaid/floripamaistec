using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_sem10.Models.Configuration
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.HasKey(x => x.Id);

            // Relationship with teacher
            builder.HasOne(x => x.Teacher)
                .WithMany(t => t.Disciplines)
                .HasForeignKey(x => x.Teacher_id)
                .HasConstraintName("FK_TeacherId_Discipline");

            builder.ToTable("Discipline");
        }
    }
}

