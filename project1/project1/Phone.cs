
using System;
using ChairProject;
using HeadphoneProject;
using StudentProject;
using CarProject;
using SquareProject;
using System.Collections;
using System.Collections.Generic;


namespace PhoneProject 
{
        

class Phone
{

    string color;
    string shape;
    int numberOfButtons;
    int ramCapacity;

    public void MakeCall()
    {

            Console.WriteLine("making a call"+ "\n");

    }

    public void SendText()
    {
            Console.WriteLine("Sending a text"+ "\n");

    }

    public void TakePicture()
    {
            Console.WriteLine("take picture"+ "\n");


    }

        public static void Main()
        {
            /* Phone myPhone;
              myPhone = new Phone();
              myPhone.color = "red";
              Console.WriteLine(myPhone.color + "\n");

              Phone myPhone1;
              myPhone1 = new Phone();
              myPhone1.color = "white";
              Console.WriteLine(myPhone1.color + "\n");

              myPhone = myPhone1;

              Console.WriteLine(myPhone.color + "\n");
              Console.WriteLine(myPhone1.color + "\n");


              Chair myChair;
              myChair = new Chair();

              Headphone myHeadphone;
              myHeadphone = new Headphone();*/

            // Student myStudent;
            //  myStudent = new Student();

            // myStudent.AttendClasses();
            // myStudent.StudyWell();


            Student myStudent;
            myStudent = new Student();
            myStudent.Height = 4;
            Console.WriteLine(myStudent.Height +"\n");


           // Calculator myCalc;
            Calculator   myCalc = new Calculator();
            myCalc.PropA = 6;
            myCalc.PropB = 7;
            Console.WriteLine(myCalc.Add());




            /*  Car myCar;
              myCar = new Car();

            //  Square mySquare;
            Square  mySquare = new Square(10);
              Console.WriteLine(mySquare.Area());

              //  mySquare.SetSide(3);
          //    mySquare.Size = 10;

          //    Console.WriteLine(mySquare.Size);



        /*      myPhone.MakeCall();
              myPhone.SendText();

              myChair.MoveAround();

              myHeadphone.ListeningToMusic();
              myHeadphone.AnsweringCalls();

              myCar.TravelAround();
              myCar.UseForBusiness();

              mySquare.UsedForDrwaing();
              mySquare.MeasuringAngles();
  */

            /* Calculator myCalc;
             myCalc = new Calculator();


             int i = (myCalc.Add(-6, 8));
             Console.WriteLine(myCalc.Add(i, 13) + "\n");

             int d = (myCalc.Add(15, 4, 6));
             Console.WriteLine(d + "\n");

             int j = (myCalc.Sub(10, 6));
             Console.WriteLine(j + "\n");

             int k = (myCalc.Mul(4, 5));
             Console.WriteLine(k + "\n");

             int l = (myCalc.Div(20, 5));
             Console.WriteLine(l + "\n");*/

            /*    Calculator myCalc1;
                myCalc1 = new Calculator();
                int a = 7;
                int b = 4;
                int c = (myCalc1.Add());
                Console.WriteLine(c +"\n");*/

            /*   List<Calculator> calcs = new List<Calculator>();

               Calculator myCalobj1;
               myCalobj1 = new Calculator();

               myCalobj1.a = 4;
               myCalobj1.b = 7;

               calcs.Add(myCalobj1);


               Calculator myCalobj2;
               myCalobj2 = new Calculator();

               myCalobj2.a = 3;
               myCalobj2.b = 6;

               calcs.Add(myCalobj2);


               Calculator myCalobj3;
               myCalobj3 = new Calculator();

               myCalobj3.a = 8;
               myCalobj3.b = 9;

               calcs.Add(myCalobj3);

               Console.WriteLine("Addition: " + "\n");

               foreach (Calculator item in calcs)
                   Console.WriteLine(item.Add() + "\n");


               Calculator myCalc2;
               myCalc2 = new Calculator();

               Calculator myCalc3;
               myCalc3 = new Calculator();

               Calculator myCalc4;
               myCalc4 = new Calculator();

               Calculator myCalc5;
               myCalc5 = new Calculator();

               /*
               Calendar myCal;
               myCal = new Calendar();


               string monname = myCal.GetMonthName(13);
               Console.WriteLine(monname + "\n");


               DaysofWeek myDaysofWeek;
               myDaysofWeek = new DaysofWeek();

               string dayname = myDaysofWeek.GetDaysName(3);
               Console.WriteLine(dayname + "\n");


               Grade myGrade;
               myGrade = new Grade();

               myGrade.GetGrade(90, 99);


               int c = 1;
               int d;

               while (c <= 10)
               {
                   d = c * c;
                   Console.WriteLine(d + "\n");
                   c += 2;

               }


               for (int x = 1; x <= 10; x++)
               {
                   int y = 7 * x;
                   Console.WriteLine(y + "\n");

               }

               Console.WriteLine("Multiplication table for 7: " + "\n");

               for (int x = 1; x <= 10; x++)

               {
                   int y = 7 * x;
                   Console.WriteLine("7 * "+ x +" = "+y +"\n");
               }


             int[] grades = new int[5];
               grades[0] = 100;
               grades[1] = 0;
               grades[2] = 40;
               grades[3] = 40;
               grades[4] = 20;


               for (int e = 1; e < 5; e++)
               {
                   Console.WriteLine(grades[e]);
               }

               for (int e=1; e < 10.length; e++)
                 {
                     Console.WriteLine(grade[e]);
                 }

                foreach(int grades in grade)
                    Console.WriteLine(grades);

               List<int> grades = new List<int>();
                  grades.Add(100);
                  grades.("test");

                  for (int e = 0; e<grades.Count; e++ )
                      {   
                          Console.WriteLine(grades[e]+"\n");

                      }


              ISet<int> grades = new Set<int>();
                 Grade myGradeobj1;
                 myGradeobj1 = new Grade();

               grades.Add(100);
               grades.Add(100);
               grades.Add(200);


              List<Phone> phones = new List<Phone>();

               Phone myPhoneobj;
               myPhoneobj = new Phone();

               myPhoneobj.color = "red";

               phones.Add(myPhoneobj);


               Phone myPhoneobj1;
               myPhoneobj1 = new Phone();

               myPhoneobj1.color = "black";

               phones.Add(myPhoneobj1);



               Phone myPhoneobj2;
               myPhoneobj2 = new Phone();

               myPhoneobj2.color = "blue";

               phones.Add(myPhoneobj2);


               foreach (Phone item in phones)
                   Console.WriteLine(item.color);

               HashSet<Phone> phones = new HashSet<Phone>();

               Phone myPhoneobj3;
               myPhoneobj3 = new Phone();

               myPhoneobj3.numberOfButtons = 1;

               phones.Add(myPhoneobj3);


               Phone myPhoneobj4;
               myPhoneobj4 = new Phone();

               myPhoneobj4.numberOfButtons = 2;

               phones.Add(myPhoneobj4);
               phones.Add(myPhoneobj4);


               Phone myPhoneobj5;
               myPhoneobj5 = new Phone();

               myPhoneobj5.numberOfButtons = 3;

               phones.Add(myPhoneobj5);


               Phone myPhoneobj6;
               myPhoneobj6 = new Phone();

               myPhoneobj6.numberOfButtons = 4;

               phones.Add(myPhoneobj6);


               Phone myPhoneobj7;
               myPhoneobj7 = new Phone();

               myPhoneobj7.numberOfButtons = 5;

               phones.Add(myPhoneobj7);


               Phone myPhoneobj8;
               myPhoneobj8 = new Phone();

               myPhoneobj8.numberOfButtons = 6;

               phones.Add(myPhoneobj8);

               Console.WriteLine("Creating a Set to add different values: " + "\n");

               foreach (Phone item in phones)
                   Console.WriteLine(item.numberOfButtons);





           }*/

        }
}
}
