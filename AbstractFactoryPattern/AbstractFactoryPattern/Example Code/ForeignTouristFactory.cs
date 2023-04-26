namespace AbstractFactoryPattern.Example_Code;

public class ForeignTouristFactory : IKitchen
{
    public IVeg vegFood()
    {
        return new NepaliFood();
    }

    public INonVeg nonVegFood()
    {
        return new Chinese();
    }
}