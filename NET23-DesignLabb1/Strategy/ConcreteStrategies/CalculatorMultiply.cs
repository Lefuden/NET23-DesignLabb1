namespace NET23_DesignLabb1.Strategy.ConcreteStrategies;
internal class CalculatorMultiply : ICalculator
{
    public int DoMath(int a, int b)
    {
        return a * b;
    }
}
