using System;
namespace Inheritance
{
    public class Landline : Phone
    {
       
            int x;
            public override void MakeCall()
            {
                Console.WriteLine("This is a Landline Phone which can make calls\n");
            }
    }
}
