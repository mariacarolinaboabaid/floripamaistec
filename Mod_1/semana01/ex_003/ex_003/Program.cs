// Criando as listas 
List<int> pares = new List<int> { };
List<int> impares = new List<int> { };

// Pedindo os números para o Usuário e fazendo a divisão entre pares e ímpares
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        pares.Add(numero);
    }
    else
    {
        impares.Add(numero);
    }
}

// Colocando em ordem crescente as listas
pares.Sort();
impares.Sort();

// Imprimindo o resultado
Console.WriteLine($"A quantidade de números pares é {pares.Count()}, e a soma totaliza o valor de {pares.Sum()}.");
Console.WriteLine($"A quantidade de números ímpares é {impares.Count()}, e a soma totaliza o valor de {impares.Sum()}.");