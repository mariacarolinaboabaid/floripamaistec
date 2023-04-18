
using System;
using labSchool.Context;
using labSchool.Models;
using labSchool.Repositories.Interfaces;

namespace labSchool.Repositories
{
	public class ProfessorRepository : IProfessorRepository
	{
        // INJEÇÃO DE DEPENDÊNCIA DO BD
        private readonly LabSchoolContext _context;

        public ProfessorRepository(LabSchoolContext context)
        {
            _context = context;
        }

        // OBTER LISTA COMPLETA DE PROFESSORES
        public List<Professor> Obter()
        {
            return _context.Professores.ToList();
        }
    }
}

