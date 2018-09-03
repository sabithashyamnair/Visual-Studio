using System;
namespace Inheritance
{
    public class Phone

    {
        int a;
        int b;

    public virtual void MakeCall()
    {
        Console.WriteLine("We can make a call on phone \n");
    }

    public void VoiceMsg()
    {
        Console.WriteLine("We can send voice message through a phone \n");
    }
}
}
