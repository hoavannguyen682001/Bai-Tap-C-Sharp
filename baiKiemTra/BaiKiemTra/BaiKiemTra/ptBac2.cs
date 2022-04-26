using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class ptBac2
    {
        private double a_217, b_217, c_217;

        public ptBac2()
        {
        }

        public ptBac2(double a_217, double b_217, double c_217)
        {
            this.a_217 = a_217;
            this.b_217 = b_217;
            this.c_217 = c_217;
        }

        public double A { get => a_217; set => a_217 = value; }
        public double B { get => b_217; set => b_217 = value; }
        public double C { get => c_217; set => c_217 = value; }

        public double delta(double a_217, double b_217, double c_217)
        { 
            return (b_217*b_217 - 4*a_217*c_217);
        }

        public void nghiemPT(double a_217, double b_217, double c_217)
        {
            double del_217 = delta(a_217, b_217, c_217);
            if (a_217 == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c_217 / b_217);
            }
            else
            {
                if (del_217 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (del_217 == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep, x1 = x2 = {0}", -b_217 / (2 * a_217));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", ((-b_217 + Math.Sqrt(del_217)) / (2 * a_217)));
                    Console.WriteLine("x2 = {0}", ((-b_217 - Math.Sqrt(del_217)) / (2 * a_217)));
                }
            }
        }
            
    }
}
