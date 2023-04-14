using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ex_sem10.Models.Configuration
{
	public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
	
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x => x.Id);

            // Relationships with students and questions
            builder.HasOne(x => x.Student)
                .WithMany(a => a.Answers)
                .HasForeignKey(x => x.Student_id)
                .HasConstraintName("FK_StudentId_Answer");

            builder.HasOne(x => x.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(x => x.Question_id)
                .HasConstraintName("FK_QuestionId_Answer");

            builder.ToTable("Answer");
        }
    }
}

