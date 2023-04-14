using System;
using ex_sem10.Context;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;

namespace ex_sem10.Repositories
{
	public class QuestionRepository : IQuestionRepository
    {
        // DbcContext >>> dependency injection
        private readonly SchoolContext _context;

        public QuestionRepository(SchoolContext context)
        {
            _context = context;
        }

        public List<Question> ObterLista()
        {
            return _context.Questions.ToList();
        }

        public Question? ObterPorId(int id)
        {
            return _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Adicionar(Question question)
        {
            _context.Questions.Add(question);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public void Atualizar(Question question)
        {
            _context.Update(question);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public bool Excluir(int id)
        {
            var question = ObterPorId(id);
            if (question == null)
            {
                return false;
            }
            _context.Questions.Remove(question);
            // Commit to save changes at the database
            _context.SaveChanges();
            return true;
        }
    }
}

