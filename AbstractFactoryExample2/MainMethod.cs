namespace AbstractFactoryPattern.AbstractFactoryExample2;

public class MainMethod
{
    public static void main(string[] args)
    {
        Iinsttitute instutute1 = FactoryProducer.GetChoice("hseb");
        ITeacher teacher1 = instutute1.viewTeacher("FULL TIME TEACHER");
        teacher1.shift();
        IStudent student1 = instutute1.viewStudent("Bachelor student");
        student1.fee();
    }
}