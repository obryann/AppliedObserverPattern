﻿using SimpleObserverPattern.Observer;

namespace SimpleObserverPattern.Subject
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Dettach(IObserver observer);
        void Notify();
    }
}
