// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1;

class Car
{
    //it is a field
    private String model;
    private int year;
    
    //it is a constructor

    public Car(string modelName, int modelyear)
    {
        model = modelName;
        year = modelyear;

    }

    public static void Main(String[] args)
    {
        Car obj = new Car("SL-200",300);
        Console.WriteLine(obj.model+" "+ obj.year);
    }
    
    
}