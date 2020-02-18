using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    public class GoogleObserver : IObserver
    {
        public void Update(WeatherStation weatherStation)
        {
            Console.WriteLine($"Google - Tempreture {weatherStation.Tempreture}");
        }
    }
}
