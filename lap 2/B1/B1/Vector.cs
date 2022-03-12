using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Vector
    {
        Point a;
        Point b;

        double x, y;
        public Vector(Point a, Point b)
        {
            this.a = a;
            this.b = b;
            x = this.a.getX() - this.b.getX();
            y = this.a.gety() - this.b.gety();
        }

        public double lenghAB()
        {
            return Math.Sqrt(x * x + y * y);

        }

        public static double Lens(Point A, Point B)
        {
            double x, y;
            x = A.getX() - B.getX();
            y = A.gety() - B.gety();

            return Math.Sqrt(x * x + y * y);
        }
    }
}
