using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.PatternApplication
{
    public class EatBehavior : IEatBehavior
    {
        public void Eat()
        {
            Console.WriteLine($"Duck eating");
        }
    }
}
