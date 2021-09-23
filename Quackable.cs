using System;

namespace Test1Practice
{
    public class Quackable : IDuckBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}
