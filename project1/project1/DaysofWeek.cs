using System;
namespace PhoneProject
{
    public class DaysofWeek
    {
       public string GetDaysName(int i)
        {
            string dayname;

            switch(i)
            {
                case 1:
                    dayname = "Mon";
                    break;

                case 2:
                    dayname = "Tue";
                    break;

                case 3:
                    dayname = "Wed";
                    break;

                case 4:
                    dayname = "Thu";
                    break;

                case 5:
                    dayname = "Fri";
                    break;

                case 6:
                    dayname = "Sat";
                    break;

                case 7:
                    dayname = "Sun";
                    break;

                default:
                    dayname= "Invalid Day Name";
                    break;

            }

            return dayname;

        }
    }
}
