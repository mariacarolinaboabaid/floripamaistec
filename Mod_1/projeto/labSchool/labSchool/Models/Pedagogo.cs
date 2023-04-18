using System;
namespace labSchool.Models
{
    // CLASSE PEDAGOGO COM HERANÇA DA CLASSE PESSOA
    public class Pedagogo : Pessoa
	{
        public int TotalAtendimentosPedagogicos { get; set; } 

        // MET PARA INCREMENTER O NÚMERO DE ATENDIMENTOS
        public void AdicionarAtendimento()
        {
            TotalAtendimentosPedagogicos += 1;
        }
    }
}

