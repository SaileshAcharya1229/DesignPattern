namespace listGeneric;

public class GenericDemo <T>
{
    public static void displayMe(List<T> something)
    {
        foreach (var a in something)
            
        {
            Console.WriteLine(a);
        }
    }
}