using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.Scenario
{
    public class CityDuck : Duck
    {
        public CityDuck()
        {
            this.DuckType = "City Duck";
        }

        public override void Move()
        {
            Console.WriteLine($"Duck Movement 1");
        }

        public override void Speak()
        {
            Console.WriteLine($"City Duck Speaking");
        }
    }
}
