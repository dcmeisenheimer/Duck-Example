using System;

namespace Test1Practice
{
    public class Mallard : Ducks
    {
        public Mallard()
        {
            QuackBehavior = new Quackable();
        }
    }
}
