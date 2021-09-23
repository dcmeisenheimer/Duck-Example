using System;

namespace Test1Practice
{
    public class RedHead : Ducks
    {
        public RedHead()
        {
            QuackBehavior = new Quackable();
        }
    }
}
