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
            public int maSV_217;
            public string hoTen_217;
            public int tuoi_217;
            public double diemToan_217;
            public double diemLy_217;
            public double diemHoa_217;
            public int gioiTinh_217;

        }
        enum gioiTinh
        {
            nam_217,
            nu_217
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.WriteLine("");
            Console.Write(" Ma so: ");
            SV.maSV_217 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.hoTen_217 = Console.ReadLine();
            Console.Write(" Gioi tinh (0 - nam, 1 - nu): ");
            SV.gioiTinh_217 = int.Parse(Console.ReadLine());
            Console.Write(" Tuoi: ");
            SV.tuoi_217 = int.Parse(Console.ReadLine());
            Console.Write(" Diem toan: ");
            SV.diemToan_217 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.diemLy_217 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.diemHoa_217 = Double.Parse(Console.ReadLine());
            
        }
        static double DiemTB(SinhVien SV)
        {
            return (SV.diemHoa_217 + SV.diemLy_217 + SV.diemHoa_217) / 3;
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine("=========");
            Console.WriteLine(" Ma so: " + SV.maSV_217);
            Console.WriteLine(" Ho ten: " + SV.hoTen_217);
            if (SV.gioiTinh_217 == 0)
            {
                Console.WriteLine(" Gioi tinh: Nam ");
            }
            if (SV.gioiTinh_217 == 1)
            {
                Console.WriteLine(" Gioi tinh: Nu");
            }
            Console.WriteLine(" Diem toan: " + SV.diemToan_217);
            Console.WriteLine(" Diem ly: " + SV.diemLy_217);
            Console.WriteLine(" Diem van: " + SV.diemHoa_217);
            Console.WriteLine(" Diem trung binh: " + DiemTB(SV));
            

        }
        static void Main(string[] args)
        { 
            
            int n_217;
            string ten_217 = "";
            Console.WriteLine("Nhap so luong sinh vien: ");

            n_217 = int.Parse(Console.ReadLine());

            SinhVien[] SV = new SinhVien[n_217];

            for (int i_217 = 0; i_217 < n_217; i_217++)
            {
                Console.Write("Nhap thong tin sinh vien thu {0}", i_217 + 1);
                NhapThongTinSinhVien(out SV[i_217]);
            }

            foreach(SinhVien sinhVien in SV)
            {
                Console.Write("Thong tin sinh vien: ");
                XuatThongTinSinhVien(sinhVien);
            }

            Console.Write("Nhap ten sinh vien can tim: ");
            ten_217 = Console.ReadLine();

            for (int i_217 = 0; i_217 < n_217; i_217++)
            {
                if (SV[i_217].hoTen_217.Equals(ten_217))
                {
                    Console.WriteLine("Diem trung binh: "+ DiemTB(SV[i_217]));
                }
            }


            Console.ReadKey();
            
        }
    }
}
