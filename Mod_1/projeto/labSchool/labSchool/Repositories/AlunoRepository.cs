using System;
using labSchool.Context;
using labSchool.Models;
using labSchool.Repositories.Interfaces;
using Microsoft.Extensions.DependencyModel;

namespace labSchool.Repository
{
	public class AlunoRepository : IAlunoRepository
    {

		// Injeção de dependência do BD
        private readonly LabSchoolContext _context;

        public AlunoRepository(LabSchoolContext context)
        {
            _context = context;
        }


        // OBTER POR ID
        public Aluno ObterPorCodigo(int cod)
        {
            return _context.Alunos.FirstOrDefault(x => x.Codigo.Equals(cod));
        }

        // ADICIONAR
        public void Adicionar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            // Commit to save changes at the database
            _context.SaveChanges();
        }

    }
}

