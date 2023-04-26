namespace BuilderDesignPattern2;

public class Director
{
    public static void Construct(IBuilder ibuilder)
    {
        ibuilder.buildPart1();
        ibuilder.buildPart2();

    }
}