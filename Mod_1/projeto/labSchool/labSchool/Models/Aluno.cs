using System;
namespace labSchool.Models
{
	// Classe Aluno herdando da classe Pessoa
	public class Aluno : Pessoa
	{
		public string SituacaoMatricula { get; set; }
		public float NotaProcessoSeletivo { get; set; }
		public int TotalAtendimentosPedagogicos { get; set; } 

        // Met. para incrementar o total de atendimentos
        public void AdicionarAtendimento()
        {
            TotalAtendimentosPedagogicos += 1;
        }
    }
}

