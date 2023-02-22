using ex_002.ex_003.ex_004.ex_005;

ContaBancaria conta_01 = new ContaBancaria(909078, 30550, "Rodrigo Silva", TipoConta.CORRENTE);

ContaBancaria conta_02 = new ContaBancaria("Karina Silva");

conta_01.Deposito(150);
conta_01.Transferencia(0, conta_02);
conta_01.Transferencia(160, conta_02);
conta_01.Transferencia(50, conta_02);


