namespace NET23_DesignLabb1.Factory.Factories;
//Implementation of Brick factory type
internal class Brick : IFactory
{
    public void Construct()
    {
        Console.WriteLine("Brick factory constructed.");
    }
}

//Implementation of Brickfactory factory
internal class BrickFactory : IFactoryFactory
{
    public IFactory Production(int amount)
    {
        Console.WriteLine($"{amount} bricks will be scheduled for production");
        return new Brick();
    }
}