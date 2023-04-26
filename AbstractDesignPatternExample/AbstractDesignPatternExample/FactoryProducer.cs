namespace AbstractDesignPatternExample;

public class FactoryProducer
{
    public static IAbsractFactory ChooseFactory(String choice)
    {
        if (choice == null)
        {
            return null;
        }

        if (choice == "shape")
        {
            return new ShapeFactory();
        }

        if (choice == "color")
        {
            return new ColorFactory();
        }

        return null;
    }
}