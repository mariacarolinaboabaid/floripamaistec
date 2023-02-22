using System;

namespace ex_002.ex_003.ex_004.ex_005
{
    // Declaração da classe
    public class ContaBancaria
    {
        // Atributos --------------------------------------------------------------------------------------------------------------------
        private int numero;
        private int agencia;
        private string nomeTitular;
        private float saldo = 0;
        private TipoConta tipoConta;


        // Construtores -----------------------------------------------------------------------------------------------------------------
        public ContaBancaria(int numero, int agencia, string nomeTitular, TipoConta tipoConta)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.nomeTitular = nomeTitular;
            this.tipoConta = tipoConta;
        }

        public ContaBancaria(string nomeTitular)
        {
            numero = 1111;
            agencia = 2222;
            this.nomeTitular = nomeTitular;
        }


        // Met. depósito ----------------------------------------------------------------------------------------------------------------
        public void Deposito(float valorDeposito = 0)
        {
            if (valorDeposito <= 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {numero} : Valor de depósito vazio ou menor ou igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"CONTA {numero} \n" +
                    $"Saldo >>> R$ {saldo}");
                saldo += valorDeposito;
                Console.WriteLine($"Depósito >>> R$ {valorDeposito} \n" +
                    $"Saldo atualizado >>> R$ {saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }

        // Met. saque ------------------------------------------------------------------------------------------------------------------
        public void Saque(float valorSaque = 0)
        {
            if (valorSaque > saldo)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {numero}: O valor do saque (R$ {valorSaque}) é maior que o valor do saldo (R$ {saldo}).\n" +
                    "-------------------------------------------------------------------------------");
            }
            else if (valorSaque == 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {numero}: Valor de saque vazio ou igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"CONTA {numero} \n" +
                    $"Saldo >>> R$ {saldo}");
                saldo -= valorSaque;
                Console.WriteLine($"Saque >>> R$ {valorSaque} \n" +
                    $"Saldo atualizado >>> R$ {saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }

        // Met. saldo -----------------------------------------------------------------------------------------------------------------
        public void Saldo()
        {
            Console.WriteLine("-------------------------------------------------------------------------------\n" +
                $"CONTA {numero} \n" +
                $"O saldo da sua conta é de R$ {saldo}. \n" +
                "-------------------------------------------------------------------------------");
        }

        // Met. Transferência ---------------------------------------------------------------------------------------------------------
        public void Transferencia(float valorTransferencia, ContaBancaria contaDestino)
        {
            if (valorTransferencia <= 0)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {numero}: Valor a ser transferido menor ou igual a zero. \n" +
                    "-------------------------------------------------------------------------------");
            }
            else if (valorTransferencia > saldo)
            {
                Console.WriteLine("-------------------------------------------------------------------------------\n" +
                    $"Error Conta n. {numero}: O valor a ser transferido (R$ {valorTransferencia}) é maior que o valor do saldo (R$ {saldo}).\n" +
                    "-------------------------------------------------------------------------------");
            }
            else
            {
                saldo -= valorTransferencia;
                contaDestino.Deposito(valorTransferencia);
                Console.WriteLine($"CONTA {numero} \n" +
                    $"Valor R$ {valorTransferencia} transferido com sucesso para a conta n. {contaDestino.numero} \n" +
                    $"Saldo atualizado >>> R$ {saldo} \n" +
                    "-------------------------------------------------------------------------------");
            }
        }
    }

    // Enum -------------------------------------------------------------------------------------------------------------------------
    public enum TipoConta
    {
        CORRENTE = 0,
        POUPANCA = 1
    }

}


