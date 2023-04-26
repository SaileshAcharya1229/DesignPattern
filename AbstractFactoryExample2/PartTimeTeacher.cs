namespace AbstractFactoryPattern.AbstractFactoryExample2;

public class PartTimeTeacher : ITeacher
{
   public void shift()
    {
        Console.WriteLine("shift of parttime teacher is 3hrs");
    }

    public void salary()
    {
        Console.WriteLine("salary of part time is 30k");
    }
}