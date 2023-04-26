public class Builder
{
    private string os;
    private string brand;
    private int battery;
    private int ram;

    public Builder setOs(String _os)
    {
        os = _os;
        return this;
    }

    public Builder setBrand(String _brand)
    {
        brand = _brand;
        return this;
    }

    public Builder setBattery(int _battery)
    {
        battery = _battery;
        return this;
    }

    public Builder setRam(int _ram)
    {
        ram = _ram;
        return this;
    }

    public Phone GetPhone()
    {
        return new Phone(os, brand, battery, ram);
    }
}