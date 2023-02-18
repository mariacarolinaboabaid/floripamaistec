// Criando a lista frutas
List<string> frutas = new List<string> { };

// Pedindo os nomes das frutas para o Usuário
for (int i = 1; i <= 15; i++)
{
    Console.Write($"Digite o nome da {i}ª fruta: ");
    string fruta = Console.ReadLine();
    frutas.Add(fruta);
}

// Colocando as frutas em ordem
frutas.Sort();

// Imprimindo o resultado
Console.Write("As frutas digitadas pelo o Usuário em ordem alfabética são: ");
foreach (var fruta in frutas)
{
   if (fruta != frutas.Last())
   {
        Console.Write(fruta + "; ");
   }
   else
   {
        Console.Write(fruta + ".");
   }
}