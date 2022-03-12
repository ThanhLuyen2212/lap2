using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Point
    {
        private double x;
        private double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() { }

        public double getX()
        {
            return x;
        }

        public double gety()
        {
            return y;
        }
    }
}
