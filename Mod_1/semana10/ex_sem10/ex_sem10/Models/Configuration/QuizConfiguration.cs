using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_sem10.Models.Configuration
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(x => x.Id);

            // Relationship with discipline
            builder.HasOne(x => x.Discipline)
                .WithMany(q => q.Quizzes)
                .HasForeignKey(x => x.Discipline_id)
                .HasConstraintName("FK_DisciplineId_Quiz");

            builder.ToTable("Quiz");
        }
    }
}

