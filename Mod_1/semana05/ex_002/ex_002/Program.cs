FileInfo arquivo = null;

// Tratamento de exceção
try
{
    
    // Pedindo ao Usuário o nome do arquivo
    Console.Write("Digite o nome do arquivo que você irá criar:  ");
    string nomeArquivo = Console.ReadLine();

    // Nova instanciação do FileInfo (crie esse arquivo)
    arquivo = new FileInfo(nomeArquivo);

    // Adicione o texto dentro do arquivo 
    using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
    {
        gravadorFluxo.WriteLine("Texto de dentro do arquivo");
    }
}

// Exceção genérica
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu o erro: {ex.Message}");
}

finally
{
    Console.WriteLine("Encerrando programa.");
    arquivo = null;
}


