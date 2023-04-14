using System;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
	public interface IQuizRepository
	{
        // Signatures
        public List<Quiz> ObterLista();
        public Quiz? ObterPorId(int id);
        public void Adicionar(Quiz quiz);
        public void Atualizar(Quiz quiz);
        public bool Excluir(int id);
    }
}

