using SimpleObserverPattern.Observer;
using SimpleObserverPattern.Subject;
using System;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Creating a new ColorObserver with {Color.Blue} color.");
            ColorObserver ObserverBlue = new ColorObserver(Color.Blue);

            Console.WriteLine($"Creating a new ColorObserver with {Color.Green} color.");
            ColorObserver ObserverGreen = new ColorObserver(Color.Green);

            ColorSubject subject = new ColorSubject();

            subject.Attach(ObserverBlue);
            subject.Attach(ObserverGreen);

            subject.ChangeColor(Color.Red);
        }
    }
}
