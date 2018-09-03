using System;
namespace Inheritance
{
    public class Mobile : Phone
    {
        int z;
        public override void MakeCall()
        {
            Console.WriteLine("This mobile phone can take pictures \n");
        }
    }
}
