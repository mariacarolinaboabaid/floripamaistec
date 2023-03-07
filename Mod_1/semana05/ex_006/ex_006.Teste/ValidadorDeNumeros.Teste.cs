namespace ex_006.Teste;
using ex_006;

public class ValidadorDeNumerosTeste
{
    [Fact]
    public void TesteEhNumeroPrimo()
    {
        bool expected = ValidadorDeNumeros.EhNumeroPrimo(4);
        Assert.False(expected);

    }

    [Fact]
    public void TesteParOuImpar()
    {
        string resultado = ValidadorDeNumeros.ParOuImpar(4);
        string expected = "Par";
        Assert.Equal(expected, resultado);

    }

    [Fact]
    public void TesteEhDiviselPor()
    {
        bool expected = ValidadorDeNumeros.EhDivisivelPor(15, 3);
        Assert.True(expected);

    }
}
