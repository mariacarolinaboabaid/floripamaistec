using System;
namespace labSchool.Models
{
    // CLASSE ALUNO COM HERANÇA DA CLASSE PESSOA
    public class Aluno : Pessoa
	{
		public string SituacaoMatricula { get; set; }
		public float NotaProcessoSeletivo { get; set; }
		public int TotalAtendimentosPedagogicos { get; set; }

        // MET PARA INCREMENTER O NÚMERO DE ATENDIMENTOS
        public void AdicionarAtendimento()
        {
            TotalAtendimentosPedagogicos += 1;
        }
    }
}

