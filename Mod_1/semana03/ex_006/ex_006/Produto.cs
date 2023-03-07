using System;

namespace ex_006
{
    internal class Produto
    {

        // Atributos
        public string nome;
        protected string cor;
        private double preco;
        private double peso;

        // Construtor
        public Produto(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public Produto()
        {

        }


        // Met.
        public void verificandoEstoque()
        {
            Console.WriteLine("Verificando estoque... \n" +
                "Acessando o método estoque da classe Produto.");
        }


        protected void vendendoProduto()
        {
            Console.WriteLine("Vendendo produto... \n" +
                "Acessando o método vender da classe Produto.");
        }


        private void descartar()
        {
            Console.WriteLine("Descartando produto...\n" +
                "Acessando o método descartar da classe Produto.");
        }

        protected void alterandoAtributoPeso(double peso)
        {
            this.peso = peso;
            Console.WriteLine($"O novo peso do produto é {peso}.");
        }
    }
}

