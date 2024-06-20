namespace NET23_DesignLabb1.Strategy.ConcreteStrategies;
internal class CalculatorSubtract : ICalculator
{
    public int DoMath(int a, int b)
    {
        return a - b;
    }
}
