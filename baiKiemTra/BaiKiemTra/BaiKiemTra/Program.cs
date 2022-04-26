using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_217, b_217, c_217;
            Console.WriteLine("Nhap a,b,c");
            a_217 = double.Parse(Console.ReadLine());
            b_217= double.Parse(Console.ReadLine());
            c_217 = double.Parse(Console.ReadLine());

            ptBac2 pt = new ptBac2();
            pt.nghiemPT(a_217, b_217, c_217);

            Console.ReadKey();
        }
    }
}
