
using System;
using ex_sem10.Context;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;

namespace ex_sem10.Repositories
{
	public class QuizRepository : IQuizRepository
    {
        // DbcContext >>> dependency injection
        private readonly SchoolContext _context;

        public QuizRepository(SchoolContext context)
        {
            _context = context;
        }

        public List<Quiz> ObterLista()
        {
            return _context.Quizzes.ToList();
        }

        public Quiz? ObterPorId(int id)
        {
            return _context.Quizzes.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Adicionar(Quiz quiz)
        {
            _context.Quizzes.Add(quiz);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public void Atualizar(Quiz quiz)
        {
            _context.Update(quiz);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public bool Excluir(int id)
        {
            var quiz = ObterPorId(id);
            if (quiz == null)
            {
                return false;
            }
            _context.Quizzes.Remove(quiz);
            // Commit to save changes at the database
            _context.SaveChanges();
            return true;
        }
    }
}

