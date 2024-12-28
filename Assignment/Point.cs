using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {
       public int x = 0, y = 0;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static double Distance(Point P1, Point P2)
        {
            double distance = 0;
            int deltaX = P1.x - P2.x;   
            int deltaY = P1.y - P2.y;
            distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }

    }

   
}
