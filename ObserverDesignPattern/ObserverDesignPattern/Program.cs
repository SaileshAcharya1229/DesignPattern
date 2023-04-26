using ObserverDesignPattern;

class Program
{
    public static void Main(string[] args)
    {
        YoutubeChannel1 obj1 = new YoutubeChannel1();
        YoutubeChannel2 obj2 = new YoutubeChannel2();

        User1 uobj1 = new User1();
        User2 uobj2 = new User2();
        User3 uobj3 = new User3();


        obj1.registerObserver(uobj1);
        obj1.notifyObserver("hello");
    }
}