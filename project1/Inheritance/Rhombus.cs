using System;
namespace Inheritance
{
    public class Rhombus : Square1
    {
        public int sideofrho;

        public Rhombus(int s)
        {

            sideofrho = s;
        }

        public int AreaOfRho()
        {
            return  2 * sideofrho;
        }

        public int PerimeterOfRho()
        {
            return 4 * sideofrho;

        }
    }
}
