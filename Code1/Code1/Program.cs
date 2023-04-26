// See https://aka.ms/new-console-template for more inf
namespace Code1;

class Car
{
    private string model;
    private string color;
    private int year;

    static void Main(string[] args)
    {
        Car Maruti = new Car();
        Maruti.model = "mustang";
        Maruti.color = "red";
        Maruti.year = 2000;

        Car suzuki = new Car();
        suzuki.model = "lastra";
        suzuki.color = "blue";
        suzuki.year = 1975;

        Console.WriteLine(Maruti.color);
        Console.WriteLine(suzuki.year);
    }
}
