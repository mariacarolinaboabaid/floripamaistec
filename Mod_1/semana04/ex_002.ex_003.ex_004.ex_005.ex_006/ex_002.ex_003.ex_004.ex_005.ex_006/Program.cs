using System;
using ex_002.ex_003.ex_004.ex_005.ex_006.Classes;

Cliente cliente00 = new Cliente("Maria Carolina", DateTime.Parse("1997-10-14"), "Programadora", "soleira", TipoPessoa.FISICA);
ContaBancaria conta00 = new ContaBancaria(1111, 2222, cliente00);

Cliente cliente01 = new Cliente("Alexandre Henrique", DateTime.Parse("1994-10-14"), "Programador", "soleiro", TipoPessoa.FISICA);
ContaPoupanca conta01 = new ContaPoupanca(3333, 4444, cliente01);

Cliente cliente02 = new Cliente("Gabriela da Silva", DateTime.Parse("1980-02-25"), "Advogada", "casada", TipoPessoa.FISICA);
ContaCorrente conta02 = new ContaCorrente(5555, 6666, cliente02);

Cliente cliente03 = new Cliente("Encanamentos LTDA", DateTime.Parse("2000-06-04"), "Serviços de encanamento", "", TipoPessoa.JURIDICA);
ContaEmpresarial conta03 = new ContaEmpresarial(5555, 6666, cliente03, 10000, 2, 0, "00.000.000/0001-01");


Console.WriteLine(value: $"Cliente 00: {conta00.Cliente.Nome}");
Console.WriteLine(value: $"Cliente 01: {conta01.Cliente.Nome}");
Console.WriteLine(value: $"Cliente 02: {conta02.Cliente.Nome}");
Console.WriteLine(value: $"Cliente 03: {conta03.Cliente.Nome}  CNPJ: {conta03.CNPJ}");

//conta03.FazerEmprestimo(11000);
//conta03.FazerEmprestimo(2000);
//conta03.PagarEmprestimo(1000);
//conta03.PagarEmprestimo(4000);

conta02.Deposito(50);
conta02.Transferencia(40, conta02);