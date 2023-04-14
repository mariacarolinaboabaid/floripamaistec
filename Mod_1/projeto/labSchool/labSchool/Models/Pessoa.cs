using System;
namespace labSchool.Models
{
    // Classe mãe
    public abstract class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
    }
}

