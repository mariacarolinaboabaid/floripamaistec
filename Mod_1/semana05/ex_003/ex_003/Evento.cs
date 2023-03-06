using System;

namespace excecoes
{
    public class Evento
    {

        int qtdLugares;
        int qtdIngressosVendidos;

        public Evento()
        {
        }

        public void ingressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!");
        }

        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }
    }
}