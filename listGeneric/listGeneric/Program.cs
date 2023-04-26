namespace listGeneric;

public class Program
{
    public static void Main(string[] args)
    {
       
        List<int> id = new List<int>() { 1, 2, 3, 4, 5, 56, 7, 8, 9 };
        GenericDemo<int>.displayMe(id);
    }
}