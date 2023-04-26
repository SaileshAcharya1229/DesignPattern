using AbstractFactoryPattern.Example_Code;

namespace AbstractFactoryPattern;

class Program
{
    public static void Main(string[] args)
    {
        /*ShapeFactory obj = new ConcreteShapeFactory();
       var a= obj.DrawRectangle();
       a.Draw();*/

        IKitchen foreignKitchen = new ForeignTouristFactory();
       IVeg foreignVeg= foreignKitchen.vegFood();
       foreignVeg.makeThuppa();
       foreignVeg.makePaneer();
       INonVeg foreignNonVeg=foreignKitchen.nonVegFood();
       foreignNonVeg.makeChicken();
       foreignNonVeg.makeMutton();


       IKitchen domestickitchen = new DomesticTouristFactory();
       IVeg domesticVeg = domestickitchen.vegFood();
       domesticVeg.makePaneer();
       domesticVeg.makeThuppa();
       INonVeg domesticNonveg = domestickitchen.nonVegFood();
       domesticNonveg.makeChicken();
       domesticNonveg.makeMutton();




    }
}

