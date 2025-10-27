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
    internal class RobertDuck : Duck
    {
        public RobertDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
            swimBehavior = new SwimWithBody();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robert Duck");
        }
    }
}
