namespace Designpattern1;

public class LaptopFactory
{
    public Laptop getNewLaptop(string str)
    {
        if (str.Equals("secured"))
            return new AppleLaptop();
        else if (str.Equals("ordered"))
            return new DellLaptop();
        else
            return new LenovoLaptop(); 
    }
}