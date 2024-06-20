namespace NET23_DesignLabb1.Factory.Factories;

//Implementation of Tile factory type
internal class Tile : IFactory
{
    public void Construct()
    {
        Console.WriteLine("Tile factory constructed.");
    }
}

//Implementation of Tilefactory factory
internal class TileFactory : IFactoryFactory
{
    public IFactory Production(int amount)
    {
        Console.WriteLine($"{amount} tiles will be scheduled for production");
        return new Brick();
    }
}
