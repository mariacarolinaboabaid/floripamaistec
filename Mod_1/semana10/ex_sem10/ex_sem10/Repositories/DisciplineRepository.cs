using System;
using ex_sem10.Context;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;

namespace ex_sem10.Repositories
{
	public class DisciplineRepository : IDisciplineRepository
	{
        // DbcContext >>> dependency injection
        private readonly SchoolContext _context;

        public DisciplineRepository(SchoolContext context)
        {
            _context = context;
        }

        public List<Discipline> ObterLista()
        {
            return _context.Disciplines.ToList();
        }

        public Discipline? ObterPorId(int id)
        {
            return _context.Disciplines.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Adicionar(Discipline discipline)
        {
            _context.Disciplines.Add(discipline);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public void Atualizar(Discipline discipline)
        {
            _context.Update(discipline);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public bool Excluir(int id)
        {
            var discipline = ObterPorId(id);
            if (discipline == null)
            {
                return false;
            }
            _context.Disciplines.Remove(discipline);
            // Commit to save changes at the database
            _context.SaveChanges();
            return true;
        }

    }
}

