namespace Designpattern1;

class FactoryMain
{
    public static void Main(string[] args)
    {
        /*Laptop obj1 = new AppleLaptop();
        Laptop obj2 = new DellLaptop();
        Laptop obj3 = new LenovoLaptop();
        
        obj1.laptopspec();
        obj2.laptopspec();
        obj3.laptopspec(); */


        LaptopFactory objLF = new LaptopFactory();
        Laptop obj1 = objLF.getNewLaptop("k xa kta kt ho");
        obj1.laptopspec();
        
    }
}