using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private int tempreature;

        public List<IObserver> Observers { get; set; }

        public WeatherStation()
        {
            this.Observers = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public int Tempreture
        {
            get
            {
                return this.tempreature;
            }

            set
            {
                this.tempreature = value;
                this.Notify();
            }
        }

        public void Notify()
        {
            if (Observers != null)
            {
                foreach (var observer in this.Observers)
                {
                    observer.Update(this);
                }
            }
        }
    }
}
