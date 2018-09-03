using System;
namespace Inheritance
{
    public class Animal
    {
        int a;
        int b;

        public virtual void Eat()
        {
            Console.WriteLine("This animal eats \n");
        }

        public void Run()
        {
            Console.WriteLine("This animal runs \n");
        }
    }
}
