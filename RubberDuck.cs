using System;

namespace Test1Practice
{
    public class RubberDuck : Ducks
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
        }
    }
}
