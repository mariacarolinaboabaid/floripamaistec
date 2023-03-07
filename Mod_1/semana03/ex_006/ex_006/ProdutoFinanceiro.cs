using System;
namespace ex_006
{
    // Declaração da classe com herança
    internal class ProdutoFinanceiro : Produto
    {
        public ProdutoFinanceiro()
        {
        }

        public ProdutoFinanceiro(string nome, string cor) : base(nome, cor)
        {
            this.nome = nome;
            this.cor = cor;

        }

        // Met.
        public void acesso()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro("Bola", "Rosa");
            Console.WriteLine("Nome: " + PF1.nome + "  Cor: " + PF1.cor);
            PF1.verificandoEstoque();
            PF1.vendendoProduto();
            PF1.alterandoAtributoPeso(99);

        }
    }
}

