namespace ObserverDesignPattern;

public class User2 : IObserver
{
    public void update(string msg)
    {
        Console.WriteLine("User 2:"+msg);
    }
}