using System;
using labSchool.Models;

namespace labSchool.Repositories.Interfaces
{
	public interface IAlunoRepository
	{
        // Assinaturas
        public Aluno ObterPorCodigo(int cod);
        public void Adicionar(Aluno aluno);
	}
}

