using AppliedObserverPattern.Shipment.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedObserverPattern.Shipment
{
    public class Order : IOrder
    {
        public Guid id { get; set; }
        public string Product { get; private set; }
        public OrderStatus orderStatus { 
            get { return orderStatus; }
            set {
                orderStatus = StatusDates.LastOrDefault().Status;
                Notify();
            } 
        }

        public Order(Guid id, string product, OrderStatus orderStatus, List<StatusDates> statusDates)
        {
            this.id = id;
            Product = product;
            this.orderStatus = orderStatus;
            StatusDates = statusDates;
        }

        private List<IObserver> _observers = new List<IObserver>();

        public List<StatusDates> StatusDates { get; private set; }

        public void Attach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Detach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }
}
