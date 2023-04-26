using System.Diagnostics;

namespace FactorypatternTopi;

public class FactoryVehicle
{
    public static IVehicle giveMe(string vehicleType)
    {
        switch(vehicleType)
        {
            case"car":
                return new Car();
            case "truck":
                return new Truck();
        }
        return null;
    }
}