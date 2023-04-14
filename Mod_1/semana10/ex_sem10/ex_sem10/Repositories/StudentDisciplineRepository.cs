using System;
using ex_sem10.Context;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;

namespace ex_sem10.Repositories
{
	public class StudentDisciplineRepository : IStudentDisciplineRepository
    {
        private readonly SchoolContext _context;

        public StudentDisciplineRepository(SchoolContext context)
        {
            _context = context;
        }


        public List<StudentDiscipline> ObterLista()
        {
            return _context.StudentsDisciplines.ToList();
        }

        public StudentDiscipline? ObterPorId(int id)
        {
            return _context.StudentsDisciplines.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Adicionar(StudentDiscipline studentDiscipline)
        {
            _context.StudentsDisciplines.Add(studentDiscipline);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public void Atualizar(StudentDiscipline studentDiscipline)
        {
            _context.Update(studentDiscipline);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public bool Excluir(int id)
        {
            var studentDiscipline = ObterPorId(id);
            if (studentDiscipline == null)
            {
                return false;
            }
            _context.StudentsDisciplines.Remove(studentDiscipline);
            // Commit to save changes at the database
            _context.SaveChanges();
            return true;
        }

    }
}


