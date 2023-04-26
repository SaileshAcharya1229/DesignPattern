namespace ObserverDesignPattern;

public interface ISubject
{
    void registerObserver(IObserver observer);
    void unregisterObserver(IObserver observer);
    void notifyObserver(string msg);
}