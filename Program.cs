using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {           
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robertDuck = new RobertDuck();
            Duck DaanDuck = new DaanDuck();

            decoyDuck.Display();
            decoyDuck.PerformFly();
            decoyDuck.PerformQuack();
            decoyDuck.PerformSwim(); 

            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
            rubberDuck.PerformSwim();

            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();

            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
            redheadDuck.PerformSwim();

            robertDuck.Display();
            robertDuck.PerformSwim();

            DaanDuck.Display();
            DaanDuck.PerformQuack();
            DaanDuck.PerformFly();
            DaanDuck.PerformSwim();


        }
    }
}