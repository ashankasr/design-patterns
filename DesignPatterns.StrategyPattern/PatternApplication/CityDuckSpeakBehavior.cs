using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.PatternApplication
{
    public class CityDuckSpeakBehavior : ISpeakBehavior
    {
        public void Speak()
        {
            Console.WriteLine($"City Duck Speaking");
        }
    }
}
