using ex_003_.ex_004_.ex_005_.ex_006.Classe;

// Instanciação da classe
ContaBancaria conta = new ContaBancaria ();

conta.numero = 111;
conta.agencia = 4055;
conta.nomeTitular = "Maria Carolina Knudsen Boabaid";



Console.WriteLine($"Titular: {conta.nomeTitular} \n" +
    $"Número Conta: {conta.numero} \n" +
    $"Agência: {conta.agencia} \n" +
    $"Saldo: R$ {conta.saldo}");

conta.Deposito();
conta.Deposito(100);

conta.Saque();
conta.Saque(150);
conta.Saque(30);

conta.Saldo();