namespace ObserverDesignPattern;

public class User3 : IObserver
{
    public void update(string msg)
    {
        Console.WriteLine("User 3:"+msg);
    }
}