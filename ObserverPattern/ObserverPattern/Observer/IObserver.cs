using SimpleObserverPattern.Subject;

namespace SimpleObserverPattern.Observer
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
