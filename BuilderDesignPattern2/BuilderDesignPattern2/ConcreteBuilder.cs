namespace BuilderDesignPattern2;

public class ConcreteBuilder : IBuilder
{
    private Product productobj = new Product();
    public void buildPart1()
    {
        productobj.Part1 = "part1";
    }

    public void buildPart2()
    {
        productobj.Part2 = "part2";
    }
    
    public Product GetDetails()
    {
        return productobj;
    }
}