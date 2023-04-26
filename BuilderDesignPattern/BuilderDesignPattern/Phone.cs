public class Phone
{
    private String os;
    private String brand;
    private int battery;
    private int ram;

    public Phone(string _os, String _brand, int _battery, int _ram)
    {
        os = _os;
        brand = _brand;
        battery = _battery;
        ram = _ram;
    }

    public override string ToString()
    {
        return $"{os} {brand} {battery} {ram}";
    }
}