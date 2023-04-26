namespace AbstractFactoryPattern.AbstractFactoryExample2;

public class FullTimeTeacher : ITeacher
{
    public void shift()
    {
        Console.WriteLine("the shift of full time teacher is 8 hrs");
    }

    public void salary()
    {
        Console.WriteLine("The salary of fulltime teacher is 60k");
    }
}