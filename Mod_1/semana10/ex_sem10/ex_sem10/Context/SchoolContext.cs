using System;
using ex_sem10.Models;
using ex_sem10.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ex_sem10.Context
{
	public class SchoolContext : DbContext 
	{

        // Tables
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDiscipline> StudentsDisciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuizConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentDisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
    }
}

