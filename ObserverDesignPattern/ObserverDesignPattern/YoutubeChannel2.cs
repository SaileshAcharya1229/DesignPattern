using System.Collections;

namespace ObserverDesignPattern;

public class YoutubeChannel2 : ISubject
{
    private List<IObserver> observerList;

    public YoutubeChannel2()
    {
        observerList = new List<IObserver>();
    }

    public void registerObserver(IObserver observer)
    {
        observerList.Add(observer);
    }

    public void unregisterObserver(IObserver observer)
    {
        int index = observerList.IndexOf(observer);
        if (index >= 0)
        {
            observerList.Remove(observer);
        }
    }

    public void notifyObserver(string msg)
    {
        foreach (IObserver observer in observerList)
        {
            observer.update(msg);
        }
    }

    
}
