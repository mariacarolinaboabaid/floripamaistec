using System;
namespace ex_002.ex_003.ex_004.ex_005.ex_006.Classes
{

    // Herança
    public class ContaCorrente : ContaBancaria
	{

		// Construtor + base
		public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
		{
            if (Cliente.tipoPessoa != TipoPessoa.FISICA)
            {
                throw new ArgumentException("Apenas pessoas físicas podem ter conta corrente!");
            }
        }

        // Mét. Sacar ----------------------------------------------------------------------------------------------------------------
        public override void Saque(decimal valorSaque = 0)
        {
            decimal valorCobranca = 0.5M;
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

            decimal valorCobranca = 0.25M;
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

