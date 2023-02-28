using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex_002.ex_003.ex_004.ex_005.ex_006.Classes
{
	public class ContaBancaria
	{

        // Auto Properties
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public decimal Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }

        // Construtor
        public ContaBancaria(int numero, int agencia, Cliente cliente)
		{
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
		}

        // Met. Depósito ----------------------------------------------------------------------------------------------------------------
        public void Deposito(decimal valorDeposito = 0)
        {
            if (valorDeposito <= 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero} : Valor de depósito vazio ou menor ou igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"CONTA {Numero} \n" +
                    $"Saldo >>> R$ {Saldo}");
                Saldo += valorDeposito;
                Console.WriteLine($"Depósito >>> R$ {valorDeposito} \n" +
                    $"Saldo atualizado >>> R$ {Saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }

        // Met. Saque ------------------------------------------------------------------------------------------------------------------
        public virtual void Saque(decimal valorSaque = 0)
        {
            if (valorSaque > Saldo)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero}: O valor do saque (R$ {valorSaque}) é maior que o valor do saldo (R$ {Saldo}).\n" +
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
                Console.WriteLine($"Saque >>> R$ {valorSaque} \n" +
                    $"Saldo atualizado >>> R$ {Saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }

        // Met. Saldo -----------------------------------------------------------------------------------------------------------------
        public void ExibirSaldo()
        {
            Console.WriteLine("-------------------------------------------------------------------------------\n" +
                $"CONTA {Numero} \n" +
                $"O saldo da sua conta é de R$ {Saldo}. \n" +
                "-------------------------------------------------------------------------------");
        }

        // Met. Transferência ---------------------------------------------------------------------------------------------------------
        public virtual void Transferencia(decimal valorTransferencia, ContaBancaria contaDestino)
        {
            if (valorTransferencia <= 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero}: Valor a ser transferido menor ou igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
            }
            else if (valorTransferencia > Saldo)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {Numero}: O valor a ser transferido (R$ {valorTransferencia}) é maior que o valor do saldo (R$ {Saldo}).\n" +
                    "-------------------------------------------------------------------------------");
            }
            else
            {
                Saldo -= valorTransferencia;
                contaDestino.Deposito(valorTransferencia);
                Console.WriteLine($"CONTA {Numero} \n" +
                    $"Valor R$ {valorTransferencia} transferido com sucesso para a conta n. {contaDestino.Numero} \n" +
                    $"Saldo atualizado >>> R$ {Saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }
    }
}

