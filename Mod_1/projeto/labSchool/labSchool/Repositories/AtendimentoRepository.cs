using System;
using labSchool.Context;
using labSchool.Controllers;
using labSchool.Models;
using labSchool.Repositories;
using labSchool.Repositories.Interfaces;

namespace labSchool.Repositories
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        // INJEÇÃO DE DEPENDÊNCIA DO BD
        private readonly LabSchoolContext _context;

        public AtendimentoRepository(LabSchoolContext context)
        {
            _context = context;
        }

        // OBTER POR ID ALUNO
        public Aluno? ObterPorCodigoAluno(int codigo)
        {
            return _context.Alunos.FirstOrDefault(x => x.Codigo.Equals(codigo));
        }

        // OBTER POR ID PEDAGOGO
        public Pedagogo? ObterPorCodigoPedagogo(int codigo)
        {
            return _context.Pedagogos.FirstOrDefault(x => x.Codigo.Equals(codigo));
        }

        // ATUALIZAR PEDAGOGO
        public void AtualizarPedagogo(Pedagogo pedagogo)
        {
            _context.Pedagogos.Update(pedagogo);
            _context.SaveChanges();
        }

        // ATUALIZAR ALUNO
        public void AtualizarAluno(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }
    }
}

