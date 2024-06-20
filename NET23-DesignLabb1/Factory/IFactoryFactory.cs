namespace NET23_DesignLabb1.Factory;
//Interface for factories that make factories
public interface IFactoryFactory
{
    IFactory Production(int amount);
}