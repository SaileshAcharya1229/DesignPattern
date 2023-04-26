using System.Collections;

namespace ObserverDesignPattern;

public class YoutubeChannel1 : ISubject
{
    private List<IObserver> observerlist;


    public YoutubeChannel1()
    {
        observerlist = new List<IObserver>();
    }

    public void registerObserver(IObserver observer)
        {
            observerlist.Add(observer);
        }

    public void unregisterObserver(IObserver observer)
    {
        int index = observerlist.IndexOf(observer);
        if (index >= 0)
        {
            observerlist.Remove(observer);
        }
        else
        {
            Console.WriteLine("No such Subscriber");
        }
    }

    public void notifyObserver(string msg)
        {
            foreach(IObserver observer in observerlist )
            {
                observer.update(msg);
            }
        }
    
            
    
}
