using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.PatternApplication
{
    public class Move1Behavior : IMoveBehavior
    {
        public void Move()
        {
            Console.WriteLine($"Duck Movement 1");
        }
    }
}
