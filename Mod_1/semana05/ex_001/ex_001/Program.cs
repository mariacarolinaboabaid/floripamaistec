using System;
List<decimal> numeros = new List<decimal> { };
// Procedendo a divisão
try
{
    
    for (int i = 1; i <= 2; i++)
    {
        Console.Write($"Digite o {i}º número: ");
        decimal numero = decimal.Parse(Console.ReadLine());
        numeros.Add(numero);
    }
    decimal resultado = numeros[0] / numeros[1];
    Console.WriteLine($"O resultado da divisão do número {numeros[0]} pelo número {numeros[1]} é {resultado}.");
}
// Exceção divisão por zero
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: o dividendo não pode ser 0. \n" +
        $"{ex.Message}");
}
// Exceção tipo de formato
catch (FormatException ex)
{
    Console.WriteLine($"Error: insira apenas dígitos numéricos.\n" +
        $"{ex.Message}");
}
// Exceção genérica 
catch (Exception ex)
{
    Console.WriteLine($"Error: ocorreu um erro. \n" +
        $"{ex.Message}");
}
// Zerando
finally
{
    numeros[0] = 0;
    numeros[1] = 0;
}