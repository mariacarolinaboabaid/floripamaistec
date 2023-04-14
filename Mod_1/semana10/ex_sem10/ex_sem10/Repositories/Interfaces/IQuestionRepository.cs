using System;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
	public interface IQuestionRepository
	{
        // Signatures
        public List<Question> ObterLista();
        public Question? ObterPorId(int id);
        public void Adicionar(Question question);
        public void Atualizar(Question question);
        public bool Excluir(int id);
    }
}

