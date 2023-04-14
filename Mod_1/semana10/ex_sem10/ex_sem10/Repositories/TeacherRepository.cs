using System;
using ex_sem10.Context;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;

namespace ex_sem10.Repositories
{
	public class TeacherRepository : ITeacherRepository
    {
        // DbcContext >>> dependency injection
        private readonly SchoolContext _context;

        public TeacherRepository(SchoolContext context)
        {
            _context = context;
        }

        // Get All
        public List<Teacher> ObterLista()
        {

            return _context.Teachers.ToList();
        }

        // Get Id
        public Teacher? ObterPorId(int id)
        {
            return _context.Teachers.FirstOrDefault(x => x.Id.Equals(id));
        }

        // Post
        public void Adicionar(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        // Put
        public void Atualizar(Teacher teacher)
        {
            _context.Update(teacher);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        // Delete
        public bool Excluir(int id)
        {
            // Capturing the answer
            var teacher = ObterPorId(id);
            if (teacher == null)
            {
                return false;
            }
            _context.Teachers.Remove(teacher);
            // Commit to save changes at the database
            _context.SaveChanges();
            return true;
        }
    }
}


