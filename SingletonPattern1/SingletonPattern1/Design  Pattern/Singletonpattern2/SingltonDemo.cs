namespace SingletonPattern1.Design__Pattern.Singletonpattern2;

public sealed class SingltonDemo
{
    private static SingltonDemo obj = null;

    private SingltonDemo()
    {
        Console.WriteLine("ENter any number:");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine("the number is even");
        }
        else
        {
            Console.WriteLine("the number is odd");
        }
    }


    public static SingltonDemo getinstance1()
    {
        if (obj == null)
        {
            obj = new SingltonDemo();
        }

        return null;
    }
}