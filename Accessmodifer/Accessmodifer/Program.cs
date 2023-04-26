// See https://aka.ms/new-console-template for more information

namespace Accessmodifier;

class Car
{
    public string name = "nexon";
    
}

class program
{
    public static void Main(String[] args)
    {
        Car obj = new Car();
        Console.WriteLine(obj.name);
    }
}