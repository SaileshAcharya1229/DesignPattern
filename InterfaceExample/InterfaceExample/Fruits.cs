namespace InterfaceExample;

public interface Fruits
{
    void FruitsColor();
}

class mango : Fruits
{
    public void FruitsColor()
    {
        Console.WriteLine("Mango are normally green in color");
    }
}

class pomo : Fruits
{
    public void FruitsColor()
    {
        Console.WriteLine("pomo are red in color");
    }
}
