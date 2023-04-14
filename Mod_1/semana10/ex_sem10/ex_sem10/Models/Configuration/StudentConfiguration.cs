using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_sem10.Models.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);

            // Relationship with user
            builder.HasOne(x => x.User)
               .WithOne(u => u.Student)
               .HasForeignKey<Student>(x => x.User_id)
               .HasConstraintName("FK_UserId_Student");

            builder.ToTable("Student");
        }
    }
}


