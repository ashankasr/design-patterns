using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.PatternApplication
{
    public class WildDuckSpeakBehavior : ISpeakBehavior
    {
        public void Speak()
        {
            Console.WriteLine($"Wild Duck Speaking");
        }
    }
}
