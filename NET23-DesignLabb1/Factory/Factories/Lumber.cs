namespace NET23_DesignLabb1.Factory.Factories;
//Implementation of Lumber factory type
internal class Lumber : IFactory
{
    public void Construct()
    {
        Console.WriteLine("Lumber factory constructed.");
    }
}

//Implementation of Lumberfactory factory
internal class LumberFactory : IFactoryFactory
{
    public IFactory Production(int amount)
    {
        Console.WriteLine($"{amount} lumber will be scheduled for production");
        return new Brick();
    }
}