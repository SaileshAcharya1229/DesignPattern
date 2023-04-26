namespace DecoratorDesignPattern1;

public class AlloyWheel : CarDecorator
{
    public AlloyWheel(ICar car) : base(car)
    {
        
    }

    public override int GetPrice()
    {
        return Car.GetPrice() + 9000;
    }
}