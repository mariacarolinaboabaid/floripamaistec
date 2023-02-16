using ex_001;

// Instanciando a Classe com o construtor c/ argumentos
Produto produto_01 = new Produto("Garrafa de água", 30.50d, 3);


// Instanciando a Classe com o construtor vazio
Produto produto_02 = new Produto();

Console.WriteLine($"1º Produto \n" +
    $"Nome: {produto_01.nome} \n" +
    $"Preço: R$ {produto_01.preco} \n" +
    $"Quantidade: {produto_01.quantidade} \n" +
    "-----------------------------------------------------------------------\n" +
    $"2º Produto: \n" +
    $"Nome: {produto_02.nome} \n" +
    $"Preço: R$ {produto_02.preco} \n" +
    $"Quantidade: {produto_02.quantidade}");