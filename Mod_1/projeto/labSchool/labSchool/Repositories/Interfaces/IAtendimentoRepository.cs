using System;
using labSchool.Models;

namespace labSchool.Repositories.Interfaces
{
	public interface IAtendimentoRepository
	{
        // ASSINATURAS
        public Aluno? ObterPorCodigoAluno(int codigo);
        public Pedagogo? ObterPorCodigoPedagogo(int codigo);
        public void AtualizarPedagogo(Pedagogo pedagogo);
        public void AtualizarAluno(Aluno aluno);
    }
}

