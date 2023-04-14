using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_sem10.Models.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);

            // Relationship with quiz
            builder.HasOne(x => x.Quiz)
                .WithMany(q => q.Questions)
                .HasForeignKey(x => x.Quiz_id)
                .HasConstraintName("FK_QuizId_Question");

            builder.ToTable("Question");
        }
    }
}

