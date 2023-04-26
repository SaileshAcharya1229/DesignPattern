namespace FactoryPattern;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter your type about father or son");
        string type = Console.ReadLine();
        I1 obj = factoryclass.getobject(type);
        Console.WriteLine(obj.name());
        Console.WriteLine(obj.age());
        //Console.ReadLine();
    }
}