using System;
namespace PhoneProject
{
    public class Grade
    {
        int a;
        int b;

        public void GetGrade(int a, int b)
        {
            if(a>80 && b<100)
            {
                Console.WriteLine("Grade A"+ "\n");
            }

            else if(a>60 && b<80)
            {
                Console.WriteLine("Grade B"+ "\n");
            }

            else if(a>0 && b<60)
            {
                Console.WriteLine("Grade C"+ "\n");
            }

            else
            {
                Console.WriteLine("Enter correct Marks"+ "\n");
            }

                
        }
    }
}
