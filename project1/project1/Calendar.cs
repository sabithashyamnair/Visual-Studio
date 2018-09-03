using System;
namespace PhoneProject
{
    public class Calendar
    {
       public string GetMonthName(int i)
        {
            string monname;

            switch(i){

            case 1:
                monname = "Jan";
                    break;

            case 2:
                monname = "Feb";
                    break;

            case 3:
                monname = "Mar";
                    break;

            case 4:
            monname = "Apr";
                    break;

                case 5:
            monname = "May";
                    break;

                case 6:
            monname = "Jun";
                    break;

                case 7:
            monname = "Jul";
                    break;

                case 8:
            monname = "Aug";
                    break;

                case 9:
            monname = "Sep";
                    break;

                case 10:
            monname = "Oct";
                    break;

                case 11:
            monname = "Nov";
                    break;


                case 12:
             monname = "Dec";
                    break;

                default :

                    monname = "invalid month";
                    break;

            }

            return monname;
        }
    }
}
