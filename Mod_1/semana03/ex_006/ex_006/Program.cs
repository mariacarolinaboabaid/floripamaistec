using ex_006;


Produto produto1 = new Produto();
produto1.nome = "Calculadora";
produto1.verificandoEstoque();

Console.WriteLine("O nome do produto é: " + produto1.nome);

ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();

classeFilha.nome = "Produto Financeiro";
classeFilha.verificandoEstoque();
classeFilha.acesso();