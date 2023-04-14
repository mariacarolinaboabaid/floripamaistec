using System;
using ex_sem10.Context;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }

        // Signatures
        public List<Student> ObterLista()
        {
            return _context.Students.ToList();
        }

        public Student? ObterPorId(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Adicionar(Student student)
        {
            _context.Students.Add(student);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public void Atualizar(Student student)
        {
            _context.Update(student);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

        public bool Excluir(int id)
        {
            var student = ObterPorId(id);
            if (student == null)
            {
                return false;
            }
            _context.Students.Remove(student);
            // Commit to save changes at the database
            _context.SaveChanges();
            return true;
        }

    }
}