using System;
namespace ex_006
{

    // Declaração da classe
    public static class ValidadorDeNumeros
    {

        // Met. Número Primo
        public static bool EhNumeroPrimo(int numero)
        {
            // Achando os divisores
            List<int> divisores = new List<int> { };
            for (int y = 1; y <= numero; y++)
            {
                if (numero % y == 0)
                {
                    divisores.Add(y);
                }
            }
            /// Retornando um valor
            if (divisores.Count() <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Met. Par ou Impar
        public static string ParOuImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return "Par";
            }
            else
            {
                return "Impar";
            }

        }

        // Met. Divisibilidade
        public static bool EhDivisivelPor(int numero1, int numero2)
        {
            if (numero1 % numero2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

