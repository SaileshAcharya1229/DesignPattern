namespace ObserverDesignPattern;

public class User1 : IObserver
{
    public void update(String msg)
    {
        Console.WriteLine("User 1:"+msg);
    }

   
}