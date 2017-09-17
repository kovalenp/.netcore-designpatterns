using System;

namespace Decorator
{
    public class TestRun
    {
        public static void Main(string[] args)
        {
            var cheese = new Cheesburger();

            var withKetchup = new Ketchup(cheese);

            var addExtraOnion = new ExtraOnion(withKetchup);

            Console.Out.WriteLine(addExtraOnion.GetName());

            Console.Out.WriteLine(addExtraOnion.GetPrice());

            Console.In.Read();
        }
    }
}
