using System;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
	public interface IStudentDisciplineRepository
	{
        // Signatures
        public List<StudentDiscipline> ObterLista();
        public StudentDiscipline? ObterPorId(int id);
        public void Adicionar(StudentDiscipline studentDiscipline);
        public void Atualizar(StudentDiscipline studentDiscipline);
        public bool Excluir(int id);
    }
}

