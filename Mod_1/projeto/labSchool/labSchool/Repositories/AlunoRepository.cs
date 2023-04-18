using System;
using labSchool.Context;
using labSchool.Models;
using labSchool.Repositories.Interfaces;
using Microsoft.Extensions.DependencyModel;

namespace labSchool.Repositories
{
	public class AlunoRepository : IAlunoRepository
    {

		// INJEÇÃO DE DEPENDÊNCIA DO BD
        private readonly LabSchoolContext _context;

        public AlunoRepository(LabSchoolContext context)
        {
            _context = context;
        }

        // OBTER LISTA COMPLETA OU OPCIONALMENTE PELO PARÂMETRO SITUAÇÃO
        public List<Aluno>? Obter(string? situacao)
        {
            if (situacao != null)
            {
                return _context.Alunos.Where(x => x.SituacaoMatricula == situacao).ToList(); ;
            }
            return  _context.Alunos.ToList();
        }

        // OBTER POR ID
        public Aluno? ObterPorCodigo(int codigo)
        {
            return _context.Alunos.FirstOrDefault(x => x.Codigo.Equals(codigo));
        }

        // EXCLUIR
        public bool Delete(int codigo)
        {
            var aluno = ObterPorCodigo(codigo);
            if (aluno == null)
            {
                return false;
            }
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
            return true;
        }

        // ATUALIZAR
        public void Atualizar(Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
        }

        // ADICIONAR
        public void Adicionar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }

        // CHECA SE HÁ ALGUM CPF JÁ REGISTRADO NO BANCO DE DADOS
        public bool CPF_Unico(string valor_cpf)
        {
            return !_context.Alunos.Any(x => x.Cpf == valor_cpf);
        }
}
}

