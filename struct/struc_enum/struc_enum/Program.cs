using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struc_enum
{
    class Program
    {
        public struct SinhVien
        {
            public int maSV;
            public string hoTen;
            public int tuoi;
            public double diemToan;
            public double diemLy;
            public double diemHoa;
            public int gioiTinh;

        }
        enum gioiTinh
        {
            nam,
            nu
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.WriteLine("");
            Console.Write(" Ma so: ");
            SV.maSV = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.hoTen = Console.ReadLine();
            Console.Write(" Gioi tinh (0 - nam, 1 - nu): ");
            SV.gioiTinh = int.Parse(Console.ReadLine());
            Console.Write(" Tuoi: ");
            SV.tuoi = int.Parse(Console.ReadLine());
            Console.Write(" Diem toan: ");
            SV.diemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.diemLy = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.diemHoa = Double.Parse(Console.ReadLine());
            
        }
        static double DiemTB(SinhVien SV)
        {
            return (SV.diemHoa + SV.diemLy + SV.diemHoa) / 3;
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine("=========");
            Console.WriteLine(" Ma so: " + SV.maSV);
            Console.WriteLine(" Ho ten: " + SV.hoTen);
            if (SV.gioiTinh == 0)
            {
                Console.WriteLine(" Gioi tinh: Nam ");
            }
            else
            {
                Console.WriteLine(" Gioi tinh: Nu");
            }
            Console.WriteLine(" Diem toan: " + SV.diemToan);
            Console.WriteLine(" Diem ly: " + SV.diemLy);
            Console.WriteLine(" Diem van: " + SV.diemHoa);
            Console.WriteLine(" Diem trung binh: " + DiemTB(SV));
            

        }
        static void Main(string[] args)
        { 
            
            int n;
            string ten="";
            Console.WriteLine("Nhap so luong sinh vien: ");

            n = int.Parse(Console.ReadLine());

            SinhVien[] SV = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap thong tin sinh vien thu {0}", i + 1);
                NhapThongTinSinhVien(out SV[i]);
            }

            foreach(SinhVien sinhVien in SV)
            {
                Console.Write("Thong tin sinh vien: ");
                XuatThongTinSinhVien(sinhVien);
            }

            Console.Write("Nhap ten sinh vien can tim: ");
            ten = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (SV[i].hoTen.Equals(ten))
                {
                    Console.WriteLine("Diem trung binh: "+ DiemTB(SV[i]));
                }
            }


            Console.ReadKey();
            
        }
    }
}
