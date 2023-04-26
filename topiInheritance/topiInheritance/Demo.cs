namespace topiInheritance;

class Demo
{
    public static void Main(string[] args)
    {
        School obj = new School();
        School obj1 = new Animal();
        obj.buy();
        obj1.buy();
        
    }
}