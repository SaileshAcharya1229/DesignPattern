public class Program
{
    public static void Main(string[] args)
    {
        Phone phoneobj = new Builder().setBrand("oppo").setBattery(5600).setOs("linux").setRam(7).GetPhone();
        Console.WriteLine(phoneobj.ToString());
    }
}