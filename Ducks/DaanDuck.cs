using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class DaanDuck : Duck
    {
        public DaanDuck() {
            quackBehavior = new QuackWithMouth();
            flyBehavior = new FlyWithWings();
            swimBehavior = new Sink();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Daan Duck");
        }
    }
}
