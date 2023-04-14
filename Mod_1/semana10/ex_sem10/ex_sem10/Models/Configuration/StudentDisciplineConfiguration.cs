using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_sem10.Models.Configuration
{
    public class StudentDisciplineConfiguration : IEntityTypeConfiguration<StudentDiscipline>
    {
        public void Configure(EntityTypeBuilder<StudentDiscipline> builder)
        {
            builder.HasKey(x => x.Id);

            // Relationship with student 
            builder.HasOne(x => x.Student)
                .WithMany(s => s.Disciplines)
                .HasForeignKey(x => x.Student_id)
                .HasConstraintName("FK_StudentId");

            // Relationship with discipline
            builder.HasOne(x => x.Discipline)
                .WithMany(d => d.Students)
                .HasForeignKey(x => x.Discipline_id)
                .HasConstraintName("FK_DisciplineId");

            builder.ToTable("Student_Discipline");
        }
    }
}


