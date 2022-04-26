using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class ptBac2
    {
        private double a, b, c;

        public ptBac2()
        {
        }

        public ptBac2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double delta(double a, double b, double c)
        { 
            return (b*b - 4*a*c);
        }

        public void nghiemPT(double a, double b, double c)
        {
            double del = delta(a, b, c);
            if (a == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c / b);
            }
            else
            {
                if (del < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (del == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep, x1 = x2 = {0}", -b / (2 * a));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", ((-b + Math.Sqrt(del)) / (2 * a)));
                    Console.WriteLine("x2 = {0}", ((-b - Math.Sqrt(del)) / (2 * a)));
                }
            }
        }
            
    }
}
