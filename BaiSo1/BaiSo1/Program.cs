using System;

namespace BaiSo1
{
    class Program
    {
        static void Main(string[] args)
        {

            int soNguyen217;
            Console.WriteLine("Nhap vao so nguyen: ");
            soNguyen217 = Convert.ToInt32(Console.ReadLine());

            if (soNguyen217 >= 0)
                Console.WriteLine("Day la so nguyen  duong");
            else
                Console.WriteLine("Day la so nguyen am");
            Console.ReadKey();

        }
    }
}
