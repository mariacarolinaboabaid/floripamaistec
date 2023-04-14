using System;
using ex_sem10.Models;

namespace ex_sem10.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        // Signatures
        public List<Student> ObterLista();
        public Student? ObterPorId(int id);
        public void Adicionar(Student student);
        public void Atualizar(Student student);
        public bool Excluir(int id);
    }
}
