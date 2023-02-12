// Criando o dicionário
Dictionary <string, int> alunosMedia = new Dictionary <string, int> ();

// Pedindo os nomes e as médias dos alunos
for (int i = 1; i <= 2; i++)
{
    Console.Write($"Digite o nome do(a) {i}º aluno(a): ");
    string aluno =  Console.ReadLine();
    Console.Write($"Digite a média do(a) {aluno}: ");
    int media = int.Parse(Console.ReadLine());
    alunosMedia.Add(aluno, media);
}

// Verificando quais alunos foram aprovados ou reprovados
foreach (string key in alunosMedia.Keys)
{
    if (alunosMedia[key] > 6)
    {
        Console.WriteLine($"{key} ---- APROVADO(A)");
    }
    else
    {
        Console.WriteLine($"{key} ---- REPROVADO(A)");
    }
}