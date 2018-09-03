using System;
namespace Inheritance
{
    public class Deer: Herbivorous, Wild
    {
        int y;
        public void ToEat()
        {
            Console.WriteLine("deer eats");
        }

        public void ToHunt()
        {
            Console.WriteLine("deer Hunts");
        }
    }
}
