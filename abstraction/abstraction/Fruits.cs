namespace abstraction;

abstract class Fruits
{
    public abstract void fruitColor();

    public void Fruitscolor()
    {
        Console.WriteLine("Color of Fruits are different");
    }
}

class Banana : Fruits
{
    public override void fruitColor()
    {
        Console.WriteLine("color of banana is yellow");
    }
    
}

class litchi : Fruits
{
    public override void fruitColor()
    {
        Console.WriteLine("Litchi is red and green");
    }
}