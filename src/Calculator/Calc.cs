namespace Calculator;

public interface ICalc
{
    decimal Sum(params decimal[] numbers);
}

public class Calc : ICalc
{
    public decimal Sum(params decimal[] numbers) =>
        numbers.Sum();
}