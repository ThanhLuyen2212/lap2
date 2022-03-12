using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap toa do so a ");
            Console.WriteLine("nhap toa do x ");
            double tamx = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do y ");
            double tamy = int.Parse(Console.ReadLine());
            Point a = new Point(tamx, tamy);
            Console.WriteLine("nhap toa do so b ");
            Console.WriteLine("nhap toa do x ");
            tamx = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do y ");
            tamy = int.Parse(Console.ReadLine());
            Point b = new Point(tamx, tamy);
            MidPoint mid = new MidPoint(a, b);
            string trungdiem = mid.midpoint().getX().ToString() + " " + mid.midpoint().gety().ToString();
            Console.WriteLine("trung dien cua ab la " + trungdiem);
            trungdiem = MidPoint.midPoint(a, b).getX().ToString() + " " + MidPoint.midPoint(a, b).gety().ToString();
            Console.WriteLine(" Phuong thuc tinh " + trungdiem);
        }
    }
}
