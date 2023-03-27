using System;


namespace Escola.Dto
{
    public class CriacaoAlunoDto
    {
        // Atributos
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataDeInclusao = DateTime.Today;
        public DateTime DataDeAlteracao = DateTime.Today;
    }
}

