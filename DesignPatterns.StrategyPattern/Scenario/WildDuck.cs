using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.Scenario
{
    public class WildDuck : Duck
    {
        public WildDuck()
        {
            this.DuckType = "Wild  Duck";
        }

        public override void Move()
        {
            Console.WriteLine($"Duck Movement 1");
        }

        public override void Speak()
        {
            Console.WriteLine($"Wild Duck Speaking");
        }
    }
}
