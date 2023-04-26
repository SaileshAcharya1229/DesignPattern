// See https://aka.ms/new-console-template for more information

namespace Accessmodifier12;

public class Person
{
    public static void Main(string[] args)
    {
        demo obj = new demo();
        obj.setRoll(1);
        obj.setName("sailesh");
        Console.WriteLine(obj.getRoll());
        Console.WriteLine(obj.getName());
    }
} 