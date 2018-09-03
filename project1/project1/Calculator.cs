using System;

namespace PhoneProject
{
    public class Calculator
    {
        private int a;
        private int b;


       public int PropA{
            get{
                return a ;
            }
            set{
                if (value <= 1)
                {
                    a = 1;
                }
                else
                    a = value;
                
            }
        }

        public int PropB

        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 1)
                {
                    b = 1;
                }
                else
                    b = value;

            }
        }

        public int Add(int a, int b)
        {
           
            return a + b;

        }

       /* public int Add(int a, int b)
        {
            if(a<0 || b<0){
                return 0;
            }

               return a+b; 

        }*/

       public int Add()
        {
            if (a < 0 || b < 0)
            {
                return 0;
            }

            return a + b;

        }

        public int Add(int a, int b, int c)
        {
            if (a < 0 || b < 0 ||c<0)
            {
                return 0;
            }

            return a + b +c;

        }


     

        public int Sub(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return 0;
            }

            return a - b;

        }

        public int Mul(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return 0;
            }

            return a * b;

        }

        public int Div(int a, int b)
        {
            if(a<0 || b<0)
            {
                return 0;
            }

            return a / b;
        }
        
    }
}
