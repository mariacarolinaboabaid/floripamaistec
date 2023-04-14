using System;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
	public interface IAnswerRepository
	{
		// Signatures
		public List<Answer> ObterLista();
		public Answer? ObterPorId(int id);
		public void Adicionar(Answer answer);
		public void Atualizar(Answer answer);
        public bool Excluir(int id);
    }
}

 