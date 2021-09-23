using System;

namespace Test1Practice
{
    public class Squeak : IDuckBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}
