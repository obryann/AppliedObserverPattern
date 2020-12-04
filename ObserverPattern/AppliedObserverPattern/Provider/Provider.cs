using AppliedObserverPattern.Shipment;
using System;

namespace AppliedObserverPattern.Provider
{
    public class Provider : IObserver
    {
        public void Update(IOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
