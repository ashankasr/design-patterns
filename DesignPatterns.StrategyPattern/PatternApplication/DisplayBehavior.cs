using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.PatternApplication
{
    public class DisplayBehavior : IDisableBehavior
    {
        public void Display(string duckType)
        {
            Console.WriteLine($"Display {duckType} type;");
        }
    }
}
