using AutoFixture;
using Calculator;

namespace UnitTests;

public class CalcTest
{
    private readonly Fixture _fixture = new();
    private readonly ICalc _calc = new Calc();

    [Fact]
    public void Sum_PositiveNumbers_ReturnsSum()
    {
        // Arrange
        decimal n1 = _fixture.Create<decimal>();
        decimal n2 = _fixture.Create<decimal>();
        decimal n3 = _fixture.Create<decimal>();

        // Act
        decimal sum = _calc.Sum(n1, n2, n3);

        // Assert
        Assert.Equal(n1 + n2 + n3, sum);
    }
}