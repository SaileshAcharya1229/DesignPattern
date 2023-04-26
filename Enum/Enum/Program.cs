using Enum.Generic_Task_1;

namespace Enum;

class kxa
{
    enum Level
    {
        Low,
        Meduim,
        High
    }

    public static void Main(string[] args)
    {
        /*Level myvar = Level.High;
        Level myvar1 = Level.Meduim;
        Level myvar2 = Level.Low;

        switch (myvar1)
        {
            case Level.High:
                Console.WriteLine("High Level");
                break;
            case Level.Meduim:
                Console.WriteLine("meduim level");
                break;
            case Level.Low:
                Console.WriteLine("low level");
                break;
        }*/
        Animal <int>a= new Animal<int>();
        int[] arr = new int[] { 1, 2, 3 };
        a.displayMe(arr);
        
    }
}

