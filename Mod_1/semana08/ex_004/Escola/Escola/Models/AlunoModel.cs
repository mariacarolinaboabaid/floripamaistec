using System;

namespace Escola.Models
{
	// Criação da classe Aluno
	public class AlunoModel : BaseModel
	{
		// Atributos
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }
    }
}

