using System;
namespace labSchool.Dto
{
    // DTO PARA CRIAÇÃO DE ALUNO
	public class AlunoAdicionarDto
	{
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string SituacaoMatricula { get; set; }
        public float NotaProcessoSeletivo { get; set; }
    }

    // DTO PARA SAÍDA DE DADOS PARA O USÁRIO
    public class AlunoSaidaDto
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

    // DTO PARA ATUALIZAÇÃO DA SITUAÇÃO DE MATRÍUCLA
    public class AlunoAtualizarSituacaoDto
    {
        public string SituacaoMatricula { get; set; }
    }

}


