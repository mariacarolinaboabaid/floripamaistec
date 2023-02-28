using System;
namespace ex_002.ex_003.ex_004.ex_005.ex_006.Classes
{

    // Herança
    public class ContaEmpresarial : ContaBancaria
	{
		// Auto Properties
		public decimal LimiteEmprestimo { get; private set; }
		public decimal TaxaJuros { get; private set; }
		public bool PossuiEmprestimo { get; private set; }
		public decimal ValorUsado { get; private set; }
		public string CNPJ { get; private set; }


        // Construtor + base
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo, decimal taxaJuros, decimal valorUsado, string cnpj) : base (numero, agencia, cliente)
		{
            if (Cliente.tipoPessoa != TipoPessoa.JURIDICA)
            {
                throw new ArgumentException("Apenas pessoas jurídicas podem ter conta empresarial!");
            }
            LimiteEmprestimo = limiteEmprestimo;
			TaxaJuros = taxaJuros;
			ValorUsado = valorUsado;
			CNPJ = cnpj;
		}

		// Mét. Empréstimo ----------------------------------------------------------------------------------------------------------------
		public void FazerEmprestimo(decimal valorEmprestimo)
		{
			if (PossuiEmprestimo == true)
			{
				Console.WriteLine("Não é possível realizar o empréstimo, primeiro, pague o anterior.");
			}
			else
			{
				if (valorEmprestimo >= LimiteEmprestimo)
				{
					Console.WriteLine($"Não é possível realizar o empréstimo, o valor solicitado (R$ {valorEmprestimo}) é maior que o seu limite (R$ {LimiteEmprestimo}).");
				}
				else
				{
					PossuiEmprestimo = true;
					Saldo += valorEmprestimo;
					ValorUsado = valorEmprestimo;
                    ExibirSaldo();
                    Console.WriteLine($"Empréstimo de R$ {valorEmprestimo} realizado com sucesso.");
                }
			}
		}

		// Mét. Empréstimo ----------------------------------------------------------------------------------------------------------------
		public void PagarEmprestimo(decimal pagamento)
		{
			decimal valorDevido = ValorUsado * TaxaJuros;
			if (valorDevido > pagamento)
			{
				Console.WriteLine($"O pagamento deve ser realizado de forma integral. Valor devido: R$ {valorDevido}");
			}
			else
			{
                PossuiEmprestimo = false;
                Saldo -= ValorUsado;
                Console.WriteLine($"Pagamento realizado com sucesso.");
            }

         }

        // Mét. Sacar ----------------------------------------------------------------------------------------------------------------
        public override void Saque(decimal valorSaque = 0)
        {
            decimal valorCobranca = 1M;
            decimal valorTotal = valorSaque + valorCobranca;

            if (valorTotal > Saldo)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero}: O valor do saque (R$ {valorSaque}) com a taxa de cobrança (R$ {valorCobranca}) é maior que o valor do saldo (R$ {Saldo}).\n" +
                    "-------------------------------------------------------------------------------");
            }
            else if (valorSaque == 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero}: Valor de saque vazio ou igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"CONTA {Numero} \n" +
                    $"Saldo >>> R$ {Saldo}");
                Saldo -= valorSaque;
                Saldo -= valorCobranca;
                Console.WriteLine($"Saque >>> R$ {valorSaque} \n" +
                    $"Taxa de saque >>> R$ {valorCobranca} \n" +
                    $"Saldo atualizado >>> R$ {Saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }


        // Met. Transferência ---------------------------------------------------------------------------------------------------------
        public override void Transferencia(decimal valorTransferencia, ContaBancaria contaDestino)
        {

            decimal valorCobranca = 0.5M;
            decimal valorTotal = valorTransferencia + valorCobranca;

            if (valorTransferencia <= 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero}: Valor a ser transferido menor ou igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
            }
            else if (valorTotal > Saldo)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero}: O valor a ser transferido (R$ {valorTransferencia}) com a taxa de cobrança (R$ {valorCobranca}) é maior que o valor do saldo (R$ {Saldo}).\n" +
                    "-------------------------------------------------------------------------------");
            }
            else
            {
                Saldo -= valorTransferencia;
                Saldo -= valorCobranca;
                contaDestino.Deposito(valorTransferencia);
                Console.WriteLine($"CONTA {Numero} \n" +
                    $"Valor R$ {valorTransferencia} transferido com sucesso para a conta n. {contaDestino.Numero} \n" +
                    $"Taxa de transferência >>> R$ {valorCobranca} \n" +
                    $"Saldo atualizado >>> R$ {Saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }
    }
}

