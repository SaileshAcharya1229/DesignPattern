namespace multipleinterface;

public interface Ifirstinterface
{
    void firstinterfacekomethod();
}

public interface Isecondinterface
{
    void secondinterfacekomethod();
}

class Demo : Ifirstinterface, Isecondinterface
{
    public void firstinterfacekomethod()
    {
        Console.WriteLine(" k xa topi");
    }

    public void secondinterfacekomethod()
    {
        Console.WriteLine("thikcha chinggari dost");
    }
}