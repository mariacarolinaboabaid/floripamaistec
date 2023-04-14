using System;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
	public interface ITeacherRepository
	{
        // Signatures
        public List<Teacher> ObterLista();
        public Teacher? ObterPorId(int id);
        public void Adicionar(Teacher teacher);
        public void Atualizar(Teacher teacher);
        public bool Excluir(int id);
    }
}

