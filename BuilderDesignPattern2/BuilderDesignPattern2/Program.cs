namespace BuilderDesignPattern2;

public class Program
{
    public static void Main(string[] args)
    {
        
        IBuilder builder = new ConcreteBuilder();
        Director.Construct(builder);

        
        Product product = builder.GetDetails();
        Console.WriteLine(product.Part1);
        Console.WriteLine( product.Part2);
       

    }
}