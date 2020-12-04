using SimpleObserverPattern.Subject;
using System;

namespace SimpleObserverPattern.Observer
{
    public class ColorObserver : IObserver
    {
        public Color AttributeColor;

        public ColorObserver(Color attributeColor)
        {
            AttributeColor = attributeColor;
        }

        public void Update(ISubject subject)
        {
            Console.WriteLine($"Attribute Color was {AttributeColor}");
            AttributeColor = (subject as Subject.ColorSubject).Color;
            Console.WriteLine($"Now, it is {AttributeColor}, because Subject Color was {(subject as Subject.ColorSubject).Color}");
        }
    }
}
