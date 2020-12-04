using SimpleObserverPattern.Observer;
using System;
using System.Collections.Generic;

namespace SimpleObserverPattern.Subject
{
    public class ColorSubject : ISubject
    {
        public Color Color { get; set; }
        private List<IObserver> Observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers... \n");
            Observers.ForEach(observer =>
                observer.Update(this)
            );
        }

        public void ChangeColor(Color color)
        {
            Console.WriteLine($"Changing Observers colors to {color}");
            this.Color = color;

            this.Notify();
        }
    }

    public enum Color
    {
        Red,
        Blue,
        Green
    }
}
