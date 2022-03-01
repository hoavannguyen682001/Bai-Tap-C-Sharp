using System;

namespace BaiSo3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a217, b217, c217;
            Console.WriteLine("Nhap 3 so thuc: ");
            a217 = Convert.ToDouble(Console.ReadLine());
            b217 = Convert.ToDouble(Console.ReadLine());
            c217 = Convert.ToDouble(Console.ReadLine());

            if (a217 + b217 > c217 && a217 + c217 > b217 && b217 + c217 > a217)
                Console.WriteLine("Day la 3 canh cua mot tam giac");
            else
                Console.WriteLine("Day khong phai la 3 canh cua mot tam giac");

            Console.ReadKey();
        }
    }
}
