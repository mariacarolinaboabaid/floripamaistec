namespace ex_004.ex_005.Teste;
using ex_004.ex_005;

public class CalculadoraTeste
{

    // Teste somar --------------------------------------------------------------------------------------------------------------------
    [Fact]
    public void TesteSomaInteiro()
    {
        int resultado = Calculadora.Somar(5, 5);
        int esperado = 10;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSomaDouble()
    {
        double resultado = Calculadora.Somar(11.111, 22.222);
        double esperado = 33.333;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSomaFloat()
    {
        float resultado = Calculadora.Somar(1.1f, 2.2f);
        float esperado = 3.3f;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSomaDecimal()
    {
        decimal resultado = Calculadora.Somar(14.5M, 11.3M);
        decimal esperado = 25.8M;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSomaLong()
    {
        long resultado = Calculadora.Somar(130000L, 100000L);
        long esperado = 230000L;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    // Teste subtrair -----------------------------------------------------------------------------------------------------------------
    [Fact]
    public void TesteSubtracaoInteiro()
    {
        int resultado = Calculadora.Subtrair(5, 2);
        int esperado = 3;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSubtracaoDouble()
    {
        double resultado = Calculadora.Subtrair(22.222, 11.111);
        double esperado = 11.111;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSubtracaoFloat()
    {
        float resultado = Calculadora.Subtrair(2.2f, 1.1f);
        float esperado = 1.1f;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSubtracaoDecimal()
    {
        decimal resultado = Calculadora.Subtrair(14.5M, 12.2M);
        decimal esperado = 2.3M;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteSubtracaoLong()
    {
        long resultado = Calculadora.Subtrair(130000L, 100000L);
        long esperado = 30000L;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    // Teste multiplicar ---------------------------------------------------------------------------------------------------------------
    [Fact]
    public void TesteMultiplicarInteiro()
    {
        int resultado = Calculadora.Multiplicar(5, 3);
        int esperado = 15;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteMultiplicarDouble()
    {
        double resultado = Calculadora.Multiplicar(22.22, 22.22);
        double esperado = 493.7284;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteMultiplicarFloat()
    {
        float resultado = Calculadora.Multiplicar(2.2f, 2.2f);
        float esperado = 4.84f;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteMultiplicarDecimal()
    {
        decimal resultado = Calculadora.Multiplicar(11.1M, 11.1M);
        decimal esperado = 123.21M;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteMultiplicarLong()
    {
        long resultado = Calculadora.Multiplicar(11000L, 11000L);
        long esperado = 121000000L;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    // Teste divisão ------------------------------------------------------------------------------------------------------------------
    [Fact]
    public void TesteDividirInteiro()
    {
        decimal resultado = Calculadora.Dividir(4, 2);
        decimal esperado = 2;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteDividirDouble()
    {
        double resultado = Calculadora.Dividir(22.22, 11.11);
        double esperado = 2;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteDividirFloat()
    {
        float resultado = Calculadora.Dividir(4.4f, 2.2f);
        float esperado = 2f;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteDividirDecimal()
    {
        decimal resultado = Calculadora.Dividir(14.4M, 7.2M);
        decimal esperado = 2M;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


    [Fact]
    public void TesteDividirLong()
    {
        long resultado = Calculadora.Dividir(100000L, 5000L);
        long esperado = 20;
        // Comparação entre o resultado e o resultado esperado
        Assert.Equal(esperado, resultado);
    }


}
