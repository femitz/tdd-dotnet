namespace Test;
using src.NewTalents;

public class CalculadoraTest
{
    private Calculadora _calc = new Calculadora();

    [Theory]
    [InlineData(5, 5, 10)]
    [InlineData(10, 5, 15)]
    public void TestCalculadoraSomar(int x, int y, int resultado)
    {
        // Act
        int resultadoCalculadora = _calc.Somar(x, y);

        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(15, 5, 10)]
    [InlineData(20, 10, 10)]
    public void TestCalculadoraSubtrair(int x, int y, int resultado)
    {
        // Act
        int resultadoCalculadora = _calc.Subtrair(x, y);
        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(5, 2, 10)]
    [InlineData(5, 10, 50)]
    public void TestCalculadoraMultiplicar(int x, int y, int resultado)
    {
        // Act
        int resultadoCalculadora = _calc.Multiplicar(x, y);
        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(50, 10, 5)]
    public void TestCalculadoraDividir(int x, int y, int resultado)
    {
        // Act
        int resultadoCalculadora = _calc.Dividir(x, y);
        // Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestCalculadoraDividirPorZero()
    {
        // Arrange
        int x = 3;
        int y = 0;

        // Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(x,y));
    }
}