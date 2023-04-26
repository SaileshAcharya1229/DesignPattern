namespace AbstractDesignPatternExample;

class Program
{
    public static void Main(string[] args)
    {
        IAbsractFactory abstractobject = FactoryProducer.ChooseFactory("shape");
        IShape shape1 = new Circle();
        shape1.Size();
    }
}

