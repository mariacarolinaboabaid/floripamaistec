// Declarando as variáveis
int x = 1;
int y = 0;
int z = 0;

// Pedindo um número para o Usuário
Console.Write($"Digite um número: ");
int numero = int.Parse(Console.ReadLine());

// Criando a sequência de Fibonacci
Console.Write("A sequência de Fibonnaci é: ");
for (int i = 0; i < numero; i++)
{
    z = x + y;
    Console.Write(" " + z + " ");
    y = x;
    x = z;
}

