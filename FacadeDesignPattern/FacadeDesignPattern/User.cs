namespace FacadeDesignPattern;

public class User
{
    public static void Main(string[] args)
    {
        RoomLight obj1 = new RoomLight();
        Television obj2 = new Television();
        SoundSystem obj3 = new SoundSystem();

        HomeThreateFacade facade = new HomeThreateFacade(obj1, obj2, obj3);
        facade.watchMovie();
        
    }
}