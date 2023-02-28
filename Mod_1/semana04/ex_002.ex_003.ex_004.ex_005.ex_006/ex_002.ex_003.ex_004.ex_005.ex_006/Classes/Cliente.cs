using System;
namespace ex_002.ex_003.ex_004.ex_005.ex_006.Classes
{
    public class Cliente
    {

        // Auto Properties
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public TipoPessoa tipoPessoa { get; private set; }


        // Construtor
        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoa tipoPessoa)
        {

            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            this.tipoPessoa = tipoPessoa;

        }
    }

    // Enum
    public enum TipoPessoa
    {
        FISICA = 1,
        JURIDICA = 2
    }
}
