using System;
using labSchool.Models;

namespace labSchool.Repositories.Interfaces
{
	public interface IAlunoRepository
	{
        // ASSINATURAS
        public List<Aluno>? Obter(string? situacao);
        public Aluno? ObterPorCodigo(int codigo);
        public bool Delete(int codigo);
        public void Atualizar(Aluno aluno);
        public void Adicionar(Aluno aluno);
        public bool CPF_Unico(string valor_cpf);

    }
}

