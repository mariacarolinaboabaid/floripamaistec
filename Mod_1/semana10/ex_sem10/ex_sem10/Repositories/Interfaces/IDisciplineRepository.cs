using System;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
	public interface IDisciplineRepository
	{
        // Signatures
        public List<Discipline> ObterLista();
        public Discipline? ObterPorId(int id);
        public void Adicionar(Discipline discipline);
        public void Atualizar(Discipline discipline);
        public bool Excluir(int id);
    }
}

