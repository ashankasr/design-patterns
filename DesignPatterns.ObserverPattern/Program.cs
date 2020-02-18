using System;

namespace DesignPatterns.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();

            GoogleObserver googleCLient = new GoogleObserver();
            NewsStationObserver newStation = new NewsStationObserver();

            station.Add(googleCLient);
            station.Add(newStation);

            station.Tempreture = -10;

            Console.ReadLine();
        }
    }
}
