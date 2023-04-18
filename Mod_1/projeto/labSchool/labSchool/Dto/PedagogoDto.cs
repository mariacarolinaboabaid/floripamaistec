using System;
namespace labSchool.Dto
{
    // DTO PARA SAÍDA DE DADOS PARA O USÁRIO
    public class PedagogoSaidaDto
	{
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public int TotalAtendimentosPedagogicos { get; set; }
    }
}

