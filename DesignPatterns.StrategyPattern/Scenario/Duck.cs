using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.Scenario
{
    public abstract class Duck
    {
        public String DuckType { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Display {this.DuckType} type;");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"Duck eating");
        }

        public virtual void Move()
        {
            Console.WriteLine($"Duck flying");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"Duck Speaking");
        }
    }
}
