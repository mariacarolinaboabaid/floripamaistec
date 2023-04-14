using System;
namespace labSchool.Dto
{
	public class AlunoAdicionarDto
	{
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string SituacaoMatricula { get; set; }
        public float NotaProcessoSeletivo { get; set; }
    }

    public class AlunoCriadoSaidaDto
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string SituacaoMatricula { get; set; }
        public float NotaProcessoSeletivo { get; set; }
        public int TotalAtendimentosPedagogicos { get; set; }
    }
}


