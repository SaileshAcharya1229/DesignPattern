// See https://aka.ms/new-console-template for more information

namespace inheritance;

class vehicle
{
    public string brand = "suzuki";

    public void horn()
    {
        Console.WriteLine(" poong poong!");
    }
    
}

class car : vehicle
{
    public string modelName = "mustang";
}

class program
{
    public static void Main(string[] args)
    {
        car obj = new car();
        obj.horn();
        Console.WriteLine(obj.brand +"  "+ obj.modelName);
    }
}