namespace FactorypatternTopi;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ENter the vehicle type:");
        string type = Console.ReadLine();
        IVehicle obj = FactoryVehicle.giveMe(type);
        Console.WriteLine(obj.wheels());
        Console.WriteLine(obj.model());
        
    }
}

