using System;
namespace Inheritance
{
    public class Herbivorous : Animal
    {
        int z;
        public override void Eat()
        {
            Console.WriteLine("This animal chews \n");
        }
    }
}
