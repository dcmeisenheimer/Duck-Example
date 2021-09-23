using System.Collections.Generic;
using System;

namespace Test1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Ducks myDuck = new Ducks();
            Ducks mallard = new Mallard(){Name = "Mallard"};
            Ducks redHead = new RedHead(){Name = "RedHead"};
            Ducks rubberDuck = new RubberDuck(){Name = "Rubber Duck"};

            myDuck.QuackBehavior.Quack();
            mallard.QuackBehavior.Quack();
            redHead.QuackBehavior.Quack();
            rubberDuck.QuackBehavior.Quack();

            List<IDuckBehavior> myDucks = new List<IDuckBehavior>();
            myDucks.Add(myDuck);
            myDucks.Add(mallard);
            myDucks.Add(redHead);
            myDucks.Add(rubberDuck);

            foreach (Ducks duck in myDucks)
            {
                duck.QuackBehavior.Quack();
            }
            myDuck.Fly();
            
        }
    }
}
