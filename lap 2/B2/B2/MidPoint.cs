using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class MidPoint
    {
        Point a, b;

        public MidPoint(Point a, Point b)
        {
            this.a = a;
            this.b = b;
        }

        public Point midpoint()
        {
            double x = (a.getX() + b.getX()) / 2;
            double y = (a.gety() + b.gety()) / 2;
            return new Point(x, y);
        }

        public Point midPoint()
        {
            double x = (a.getX() + b.getX()) / 2;
            double y = (a.gety() + b.gety()) / 2;
            return new Point(x, y);
        }

        public static Point midPoint(Point a, Point b)
        {
            double x = (a.getX() + b.getX()) / 2;
            double y = (a.gety() + b.gety()) / 2;
            return new Point(x, y);
        }
    }
}
