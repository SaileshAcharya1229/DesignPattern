namespace AbstractFactoryPattern.Example_Code;

public class NepaliFood : IVeg
{
    public void makePaneer()
    {
        Console.WriteLine("This is nepali Veg  Paneer");
    }

    public void makeThuppa()
    {
        Console.WriteLine("This is nepali veg thuppa");
    }

   
}