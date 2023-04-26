namespace AbstractFactoryPattern.Example_Code;

public class DomesticTouristFactory : IKitchen
{
    public IVeg vegFood()
    {
        return new IndianFood();
        
    }

    public INonVeg nonVegFood()
    {
        return new JapneseFood();
    }
}