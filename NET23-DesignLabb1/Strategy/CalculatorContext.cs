namespace NET23_DesignLabb1.Strategy;
internal class CalculatorContext
{
    private ICalculator _calculator;

    public CalculatorContext() { }

    public CalculatorContext(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public void SetCalculator(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public void MakeMathHappen(int a, int b)
    {
        Console.WriteLine("This is where the mathmagic happens");
        var result = _calculator.DoMath(a, b);
        Console.WriteLine($"Result: {result}");
    }
}
