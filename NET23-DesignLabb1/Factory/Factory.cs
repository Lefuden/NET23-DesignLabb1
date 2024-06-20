using NET23_DesignLabb1.Factory.Factories;

namespace NET23_DesignLabb1.Factory;
//This is factory method. I had no idea what to make as an example so I made a factory that makes factories.
internal class Factory
{
    private readonly List<Tuple<string, IFactoryFactory>> _factoryList;

    public Factory()
    {
        _factoryList = new List<Tuple<string, IFactoryFactory>>();
        AddFactory<BrickFactory>("Brick Factory");
        AddFactory<TileFactory>("Tile Factory");
        AddFactory<LumberFactory>("Lumber Factory");
    }

    private void AddFactory<T>(string factoryType) where T : IFactoryFactory, new()
    {
        _factoryList.Add(Tuple.Create(factoryType, (IFactoryFactory)Activator.CreateInstance(typeof(T))!));
    }

    public IFactory BuildFactory()
    {
        Console.WriteLine("This is a factory that makes factories");
        for (int index = 0; index < _factoryList.Count; index++)
        {
            var tuple = _factoryList[index];
            Console.WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            Console.Write("Select factory type: ");
            if (int.TryParse(Console.ReadLine(), out int i) && i >= 0 && i < _factoryList.Count)
            {
                Console.Write("Set initial production amount: ");
                if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
                {
                    return _factoryList[i].Item2.Production(input);
                }
            }
            Console.WriteLine("Invalid input.\n");
        }
    }
}