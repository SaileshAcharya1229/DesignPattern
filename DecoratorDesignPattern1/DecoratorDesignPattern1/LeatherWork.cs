namespace DecoratorDesignPattern1;

public class LeatherWork : CarDecorator
{
    public LeatherWork(ICar car) : base(car)
    {
        
    }

    public override int GetPrice()
    {
        return Car.GetPrice() + 9000;
    }
}