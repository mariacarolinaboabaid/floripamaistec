using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace ex_003_.ex_004_.ex_005_.ex_006.Classe
{
	// Declaração da classe
	public class ContaBancaria
	{
		// Atributos
		public int numero;
		public int agencia;
		public string nomeTitular;
		public float saldo = 0;

		// Enum
		public enum TipoConta
		{
			CORRENTE = 0,
			POUPANCA = 1
		}

		// Met. depósito
		public void Deposito(float valorDeposito = 0)
		{
			
			if (valorDeposito <= 0)
			{
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
					"Error: Valor de depósito vazio ou menor igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
			}
			else
			{
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"SALDO: R$ {saldo}");
                saldo += valorDeposito;
                Console.WriteLine($"DEPÓSITO: R$ {valorDeposito} \n" +
                    $"SALDO ATUALIZADO: R$ {saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
		}

		// Met. saque
		public void Saque(float valorSaque = 0)
		{
			if (valorSaque > saldo)
			{
				Console.WriteLine("-------------------------------------------------------------------------------\n" +
					$"Error: O valor do saque (R$ {valorSaque}) é maior que o valor do saldo (R$ {saldo}).\n" +
					"-------------------------------------------------------------------------------");
			}
			else if (valorSaque == 0)
			{
				Console.WriteLine("-------------------------------------------------------------------------------\n" +
					"Error: Valor de saque vazio ou igual a zero. \n" +
					"-------------------------------------------------------------------------------");
			}
			else
			{
				Console.WriteLine("-------------------------------------------------------------------------------\n" +
					$"SALDO: R$ {saldo}");
				saldo -= valorSaque;
				Console.WriteLine($"SAQUE: R$ {valorSaque} \n" +
					$"SALDO ATUALIZADO: R$ {saldo} \n" +
					"-------------------------------------------------------------------------------");
			}
		}


		// Met. saldo
		public void Saldo()
		{
			Console.WriteLine("-------------------------------------------------------------------------------\n" +
				$"O saldo da sua conta é de R$ {saldo}. \n" +
                "-------------------------------------------------------------------------------");
		}
	}

}

