// Importação de biblioteca

// Nome da classe

// Declaração de método

// Declaração de variáveis
int opcao, numero1, numero2;
float resultado;

// Entradas
Console.Write("Escolha uma operação:  \n\n" +
    "1 - Soma \n" +
    "2 - Subtração \n" +
    "3 - Multiplicação \n" +
    "4 - Divisão \n" +
    "5 - Sair \n\n" +
    "Digite a opção escolhida: ");

opcao = int.Parse(Console.ReadLine());

// Processamento
switch(opcao)
{
    case 1:
        Console.WriteLine("Operação somar.");

        Console.Write("Digite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número 2: ");
        numero2 = int.Parse(Console.ReadLine());

        resultado = numero1 + numero2;
        Console.WriteLine("Resultado: " + resultado);
        break;

    case 2:
        Console.WriteLine("Operação subtração.");
        break;

    case 3:
        Console.WriteLine("Operação multiplicação.");
        break;

    case 4:
        Console.WriteLine("Operação divisão.");
        break;

    case 5:
        Console.WriteLine("Saindo do sistema.");
        break;
}

// Saídas
int num1 = 10;
float num2 = 0.9f;

Console.WriteLine(num1 + num2);