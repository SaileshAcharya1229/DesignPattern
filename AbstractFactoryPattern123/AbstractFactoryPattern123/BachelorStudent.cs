using AbstractFactoryPattern.AbstractFactoryExample2;

namespace AbstractFactoryPattern123.AbstractFactoryExample2;

public class BachelorStudent:IStudent
{
    public void shift()
    {
        Console.WriteLine("the shift of bachelor student is 6 to 9 am");
    }

    public void fee()
    {
        Console.WriteLine("the fee of bachelor student is 5k per months");
    }
    
}