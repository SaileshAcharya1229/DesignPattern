namespace polymorphism;

class Fruits
{
    public virtual void FruitColor()
    {
        Console.WriteLine("we eat fruits ");
    }
}

class Apple : Fruits
{
    public override void FruitColor()
    {
        Console.WriteLine("Apple is red in color");
    }
}

class Banana : Fruits
        {
            public override void FruitColor()
            {
                Console.WriteLine("banana is yellow in color");
            }
        }
    


class Program
{
    public static void Main(string[] args)
    {
        Fruits myfruit = new Fruits();
        Fruits myapple = new Apple();
        Fruits mybanana = new Banana();
        
        myfruit.FruitColor();
        myapple.FruitColor();
        mybanana.FruitColor();
    }
}