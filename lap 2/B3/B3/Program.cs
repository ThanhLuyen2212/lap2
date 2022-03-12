using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap ten sinh vien");
            string Name = Console.ReadLine();
            Console.WriteLine("nhap tuoi sinh vien");
            int Age = int.Parse(Console.ReadLine());

            Student student = new Student(Name, Age);
            Console.WriteLine("tuoi sinh vien nay la " + student.Age().ToString());
            Console.WriteLine("tuoi sinh vien theo phuong thuc tinh " + Student.Static_Age(student));
        }
    }
}
