using System;

namespace Test1Practice
{
    public class Ducks : IDuckBehavior
    {
        public string Name {get; set;}
        public IDuckBehavior QuackBehavior {get; set;}

        public void SetQuackBehavior(IDuckBehavior QuackBehavior)
        {
            this.QuackBehavior = QuackBehavior;
        }
        public Ducks()
        {
            QuackBehavior = new Quackable();
        }
        public virtual void Quack()
        {
            System.Console.WriteLine("Quack");
        }
        public void Fly()
        {
            System.Console.WriteLine("I'm Flying");
        }

    }
}
