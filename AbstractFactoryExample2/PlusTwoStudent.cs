namespace AbstractFactoryPattern.AbstractFactoryExample2;

public class PlusTwoStudent:IStudent
{
    public void shift()
    {
        Console.WriteLine("the shift of  +2 student is 6 to 10 am");
    }

    public void fee()
    {
        Console.WriteLine("the fee of +2 student is 4k per month ");
    }
}