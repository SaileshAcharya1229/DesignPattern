namespace SingletonPattern1.Design__Pattern.Singleton_Design_Pattern;

public sealed class SingletonDemo
{
    private static SingletonDemo obj = null;

    private SingletonDemo()
    {
        Console.WriteLine("k xa");
    }

    public static SingletonDemo getInstance()
    {
        if (obj == null)
        {
            obj = new SingletonDemo();
        }

        return obj;
    }
}