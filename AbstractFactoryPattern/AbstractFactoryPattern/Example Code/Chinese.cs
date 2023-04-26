namespace AbstractFactoryPattern.Example_Code;

public class Chinese : INonVeg
{
    public void makeMutton()
    {
        Console.WriteLine("this is chinese mutton hahaha");
    }

    public void makeChicken()
    {
        Console.WriteLine("this is chinese chicken xya");
    }
}