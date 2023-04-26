using System.Resources;

namespace AbstractFactoryPattern.Example_Code;

public class JapneseFood : INonVeg
{
    public void makeMutton()
    {
        Console.WriteLine("this is japnese mutton");
    }

    public void makeChicken()
    {
        Console.WriteLine("this is japnese chicken food");
    }
}