namespace AppliedObserverPattern.Shipment
{
    public interface IOrder
    {
        // Add listener to Order status
        void Attach(IObserver observer);

        // Removes observer from Order status
        void Detach(IObserver observer);

        // Notify all observers about an Order change.
        void Notify();
    }
}
