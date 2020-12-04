namespace AppliedObserverPattern.Shipment
{
    public interface IObserver
    {
        // Receives update from Order Status
        void Update(IOrder order);
    }
}
