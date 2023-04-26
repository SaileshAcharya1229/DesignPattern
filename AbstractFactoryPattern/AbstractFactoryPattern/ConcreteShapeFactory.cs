namespace AbstractFactoryPattern;

class ConcreteShapeFactory : ShapeFactory
{
    

    public override Circle DrawCircle()
    {
        return new Circle();
    }

    public override Rectangle DrawRectangle()
    {
        return new Rectangle();
    }
}