using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern.PatternApplication
{
    public class Duck
    {
        protected String DuckType { get; set; }
        protected IDisableBehavior displayBehavior;
        protected IEatBehavior eatBehavior;
        protected IMoveBehavior moveBehavior;
        protected ISpeakBehavior speakBehavior;

        public Duck(string type, IDisableBehavior displayBehavior, IEatBehavior eatBehavior, IMoveBehavior moveBehavior, ISpeakBehavior speakBehavior)
        {
            this.DuckType = type;
            this.displayBehavior = displayBehavior;
            this.eatBehavior = eatBehavior;
            this.moveBehavior = moveBehavior;
            this.speakBehavior = speakBehavior;
        }

        public virtual void Display()
        {
            displayBehavior.Display(this.DuckType);
        }

        public virtual void Eat()
        {
            eatBehavior.Eat();
        }

        public virtual void Move()
        {
            moveBehavior.Move();
        }

        public virtual void Speak()
        {
            speakBehavior.Speak();
        }
    }
}
