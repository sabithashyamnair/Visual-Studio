using System;

namespace SquareProject
{
    public class Square
    {
        // private int side;
        public int side;

        public  Square(int s){

            side = s;
        }


        public int Area()
        {
            return side * side;
        }

      /*  public void SetSide(int s)
        {
            if(s<=1)
            {
                side = 1;
            }
            else
                side = s;
        }

        public int GetSide()
        {
            return side;
        }*/

   /*     public int Size
        {

            get
            {
                return side;
            }

            set
            {
                if (value <= 1)
                {
                    side = 1;

                }
                else
                    side = value;

            }
        


        }*/

       
    }
}
