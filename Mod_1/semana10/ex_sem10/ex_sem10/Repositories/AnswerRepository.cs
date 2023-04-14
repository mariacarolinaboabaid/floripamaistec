using System;
using ex_sem10.Context;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;

namespace ex_sem10.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        // DbcContext >>> dependency injection
        private readonly SchoolContext _context;

        public AnswerRepository(SchoolContext context)
        {
            _context = context;
        }

        // Get All
        public List<Answer> ObterLista()
        {
            
            return _context.Answers.ToList();
        }

        // Get Id
        public Answer? ObterPorId(int id)
        {
            return _context.Answers.FirstOrDefault(x => x.Id.Equals(id));
        }

        // Post
        public void Adicionar(Answer answer)
        {
            _context.Answers.Add(answer);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        // Put
        public void Atualizar(Answer answer)
        {
            _context.Update(answer);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        // Delete
        public bool Excluir(int id)
        {
            var answer = ObterPorId(id);
            if (answer == null)
            {
                return false;
            }
            _context.Answers.Remove(answer);
            // Commit to save changes at the database
            _context.SaveChanges();
            return true;
        }
    }
}

