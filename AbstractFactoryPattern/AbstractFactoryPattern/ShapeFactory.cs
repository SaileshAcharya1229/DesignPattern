namespace AbstractFactoryPattern;

abstract class ShapeFactory
{
    public abstract Circle DrawCircle();
    public abstract Rectangle DrawRectangle();
}