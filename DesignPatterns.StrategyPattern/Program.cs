using System;

namespace DesignPatterns.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scenario...");
            Console.WriteLine(string.Empty);

            Scenario.Duck wildDuck = new Scenario.WildDuck();
            wildDuck.Display();
            wildDuck.Eat(); // Equal to base eating habit
            wildDuck.Move(); // Different from base movement but equal to city duck movement
            wildDuck.Speak(); // Different from base speaking and different to city duck speaking

            Console.WriteLine(string.Empty);

            Scenario.Duck cityDuck = new Scenario.CityDuck();
            cityDuck.Display();
            cityDuck.Eat(); // Equal to base eating habit
            cityDuck.Move(); // Different from base movement but equal to wild duck movement
            cityDuck.Speak(); // Different from base speaking and different to wild duck speaking

            Console.WriteLine(string.Empty);
            Console.WriteLine("Applying pattern...");
            Console.WriteLine(string.Empty);

            PatternApplication.Duck wildDuck2 = new PatternApplication.Duck(
                "Wild Duck",
                new PatternApplication.DisplayBehavior(),
                new PatternApplication.EatBehavior(),
                new PatternApplication.Move1Behavior(),
                new PatternApplication.WildDuckSpeakBehavior());
            wildDuck2.Display();
            wildDuck2.Eat(); // Equal to base eating habit
            wildDuck2.Move(); // Different from base movement but equal to city duck movement
            wildDuck2.Speak(); // Different from base speaking and different to city duck speaking

            Console.WriteLine(string.Empty);

            PatternApplication.Duck cityDuck2 = new PatternApplication.Duck(
                "City Duck",
                new PatternApplication.DisplayBehavior(),
                new PatternApplication.EatBehavior(),
                new PatternApplication.Move1Behavior(),
                new PatternApplication.CityDuckSpeakBehavior());

            cityDuck2.Display();
            cityDuck2.Eat(); // Equal to base eating habit
            cityDuck2.Move(); // Different from base movement but equal to city duck movement
            cityDuck2.Speak(); // Different from base speaking and different to city duck speaking

            Console.ReadLine();
        }
    }
}
