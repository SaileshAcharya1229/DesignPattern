namespace DecoratorDesignPattern1;

public class CarDecorator: ICar
{
    protected ICar Car;

    protected CarDecorator(ICar car)
    {
        Car = car;
    }

    public virtual int GetPrice()
    {
        return Car.GetPrice();
    }
}