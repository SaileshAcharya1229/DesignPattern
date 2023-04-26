namespace DecoratorDesignPattern1;

public class SunRoof : CarDecorator
{
    public SunRoof(ICar car) : base(car)
    {
        
    }

    public override int GetPrice()
    {
        return Car.GetPrice() + 4000;
    }
    
}