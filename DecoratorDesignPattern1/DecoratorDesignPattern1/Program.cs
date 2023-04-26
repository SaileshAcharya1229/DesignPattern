using DecoratorDesignPattern1;

class Program
{
    public static void Main(string[] args)
    {
        ICar car = new SUV();
        car = new AlloyWheel(car);
        car = new LeatherWork(car);
        car = new SunRoof(car);
        Console.WriteLine($"Price:{car.GetPrice()}");
    }
}