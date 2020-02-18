using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    public class NewsStationObserver : IObserver
    {
        public void Update(WeatherStation weatherStation)
        {
            Console.WriteLine($"News - Tempreture {weatherStation.Tempreture}");
        }
    }
}
