using System;

// Escopo da classe 
namespace ex_001
{
	// Criando a Classe
	public class Produto
	{

		// Atributos
		public string nome;
		public double preco;
		public int quantidade;

        // Construtor c/ argumentos
        public Produto (string nome, double preco, int quantidade)
		{
			this.nome = nome;
			this.preco = preco;
			this.quantidade = quantidade;
		}

		// Construtor vazio
		public Produto()
        {
            nome = "Sem nome";
            preco = 0;
            quantidade = 0;
        }
    }


	
}

