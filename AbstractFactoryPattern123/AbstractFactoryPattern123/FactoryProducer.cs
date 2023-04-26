using AbstractFactoryPattern.AbstractFactoryExample2;
using AbstractFactoryPattern123.AbstractFactoryExample2;

namespace AbstractFactoryPattern123;

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