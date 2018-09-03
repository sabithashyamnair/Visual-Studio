using System;

namespace StudentProject
{
    public class Student
    {
        string name;
        string gender;
       private int height;
        int scores;


        public void AttendClasses()
        {
            Console.WriteLine("Attend Classes Everyday" + "\n");
           
        }

        public void StudyWell()
        {
            Console.WriteLine("Study the Subjects Well" + "\n");
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value <= 5)
                {
                    height = 5;
                }

                else
                    height = value;
            }
        }
            

      
    }
}
