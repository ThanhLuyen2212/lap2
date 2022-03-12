using System;

namespace B1
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
            Vector vector = new Vector(a, b);
            Console.WriteLine("do dai cua hai diem a b la " + vector.lenghAB());
            Console.WriteLine(" Phuong thuc tinh " + Vector.Lens(a, b));
        }
    }
}
