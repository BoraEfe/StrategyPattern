﻿using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new QuackWithMouth();
            flyBehavior = new FlyWithWings();
            swimBehavior = new SwimWithBody();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
