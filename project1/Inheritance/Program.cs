using System;

namespace Inheritance
{
    class Program
    {

        public static void Main()
        {
            Animal myAnimal;
             myAnimal = new Animal();
             myAnimal.Eat();
             myAnimal.Run();

             Herbivorous myHerbi;
             myHerbi = new Herbivorous();
             myHerbi.Eat();
            myHerbi.Run();


             Carnivorous myCarni;
             myCarni = new Carnivorous();
           myCarni.Hunt();
             myCarni.Eat();
             myCarni.Run();



            Deer myDeer;
            myDeer = new Deer();
            myDeer.ToEat();
            myDeer.ToHunt();







       /*    Animal animal = new Animal();
            animal.Eat();

             animal = new Herbivorous();
            animal.Eat();*/



            Phone phone = new Phone();
            phone.MakeCall();
            phone.VoiceMsg();

            phone = new Mobile();
            phone.MakeCall();

            Walkie myWalkie;
            myWalkie = new Walkie();
            myWalkie.WalkieTalkie();
            myWalkie.MakeCall();
            myWalkie.VoiceMsg();

            phone = new Landline();
            phone.MakeCall();

            Square1 mySquare1;
            mySquare1 = new Square1();
            mySquare1.side = 6;
            Console.WriteLine("Area of Square is " +mySquare1.Area()+ "\n");
            Console.WriteLine("Perimeter of Square is "+mySquare1.perimeter()+"\n");

            Rhombus myRhombus = new Rhombus(10);
            Console.WriteLine("Area of Rhombus is " +myRhombus.AreaOfRho()+ "\n");
            Console.WriteLine("Perimeter of Rhombus is "+myRhombus.PerimeterOfRho()+ "\n");
            Console.WriteLine("Area of Square in Rhombus class is " + myRhombus.Area() + "\n");
            Console.WriteLine("Perimeter of Square in Rhombus class is " + myRhombus.perimeter() + "\n");







        }

    }
}
