using AbstractFactoryPattern.AbstractFactoryExample2;

namespace AbstractFactoryPattern123.AbstractFactoryExample2;

public class Program
{
    public static void Main(string[] args)
    {
        Iinsttitute instutute1 = FactoryProducer.GetChoice("hseb");
        ITeacher teacher1 = instutute1.viewTeacher("FULL TIME TEACHER");
        teacher1.shift();
        IStudent student1 = instutute1.viewStudent("Bachelor student");
    }
}