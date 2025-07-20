namespace ObserverPattern;

public interface ISubject<T>
{
    void Subscribe(IObserver<T> observer);
    void Unsubscribe(IObserver<T> observer);
    void Notify(string message);
}