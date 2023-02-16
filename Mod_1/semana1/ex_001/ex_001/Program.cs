// Criando a lista que armazenará os números 
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

List<int> numerosUser = new List<int> { };
List<int> numerosPrimos = new List<int> { };

// Loop para solicitar os números p/ o Usuário e adicionar à lista 'numerosUser'
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());
    numerosUser.Add(numero);

    // Loop para verificar se o número dado pelo Usuário é primo 
    List<int> divisores = new List<int> { };
    for (int y = 1; y <= numero; y++)
    {
        if (numero % y == 0)
        {
            divisores.Add(y);
        }
    }

    // Adicionando à lista de número primos, caso o número primo for 
    if (divisores.Count() <= 2)
    {
        numerosPrimos.Add(numero);
    }
}

// ---------------------------------------------------------------------------------------------------------------------------------------
// Caso não haja números primos
if (numerosPrimos.Count() == 0)
{
    Console.WriteLine("Nenhum número informado pelo o Usuário é primo!");
}

// Caso haja apenas um número primo
else if (numerosPrimos.Count() == 1)
{
    Console.Write("O único número primo informado pelo Usuário é ");
    foreach (var n in numerosPrimos)
    {
        int index = numerosUser.IndexOf(n);
        Console.WriteLine($"{n} e a sua posição é {index}.");
    }
}

// Caso haja mais de um número primo
else
{
    Console.Write("Os números primos são: ");
    foreach (var n in numerosPrimos)
    {
        int index = numerosUser.IndexOf(n);
        if (n != numerosPrimos.Last())
        {
            Console.Write($"{n} (posição {index}); ");
        }
        else
        {
            Console.WriteLine($"{n} (posição {index}).");
        }
    }
}


