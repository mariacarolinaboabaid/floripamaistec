using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_sem10.Models.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);

            // Relationship with user
            builder.HasOne(x => x.User)
               .WithOne(u => u.Teacher)
               .HasForeignKey<Teacher>(x => x.User_id)
               .HasConstraintName("FK_UserId_Teacher");

            builder.ToTable("Teacher");
        }
    }
}

