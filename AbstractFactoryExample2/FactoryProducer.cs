namespace AbstractFactoryPattern.AbstractFactoryExample2;

public class FactoryProducer
{
     public static Iinsttitute GetChoice(string choice)
     {
          if (choice == "hseb")
          {
               return new HSEBFacultyFactory();
          }

          if (choice == null)
          {
               return null;
          }

          if (choice == "tu")
          {
               return new TUFacultyFactory();
          }

          return null;
     }


}