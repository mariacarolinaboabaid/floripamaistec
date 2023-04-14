using System;
namespace labSchool.Models
{
    // Classe Pedagogo herdando da classe Pessoa
    public class Pedagogo : Pessoa
	{
        public int TotalAtendimentosPedagogicos { get; set; } 

        // Met. para incrementar o total de atendimentos
        public void AdicionarAtendimento()
        {
            TotalAtendimentosPedagogicos += 1;
        }
    }
}

