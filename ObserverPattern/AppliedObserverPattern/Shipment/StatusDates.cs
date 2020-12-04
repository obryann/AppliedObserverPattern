using AppliedObserverPattern.Shipment.Enum;
using System;

namespace AppliedObserverPattern.Shipment
{
    public class StatusDates
    {
        public DateTime StatusDate { get; private set; }
        public OrderStatus Status { get; private set; }
    }
}
