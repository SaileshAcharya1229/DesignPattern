namespace AbstractFactoryPattern.Example_Code;

public class IndianFood :  IVeg
{
    public void makePaneer()
    {
        Console.WriteLine("This is Indian Panner");
    }

    public void makeThuppa()
    {
        Console.WriteLine("This is Indian Thuppa");
    }

}