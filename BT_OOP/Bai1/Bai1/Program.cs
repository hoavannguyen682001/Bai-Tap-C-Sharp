using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,cv;
            string chon;
            string hten;
            QLCB qlcb = new QLCB();
            while (true)
            {
                Console.WriteLine("a - Them moi can bo");
                Console.WriteLine("b - Tim kiem can bo");
                Console.WriteLine("c - Hien thi thong tin cac can bo");
                Console.WriteLine("x - Thoat khoi chuong trinh");

                chon = Console.ReadLine();

                switch (chon)
                {
                    case "a":
                        {

                        
                            Console.WriteLine("Them can bo: ");
                            Console.WriteLine("1 - Cong Nhan ");
                            Console.WriteLine("2 - Nhan Vien ");
                            Console.WriteLine("3 - Ky Su ");
                            Console.WriteLine("4 - Thoat!");
                            cv = int.Parse(Console.ReadLine());

                            switch (cv)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("So luong cong nhan: ");
                                        n = int.Parse(Console.ReadLine());
                                        CanBo[] cb = new CanBo[n];
                                        int capBac;
                                        for (int i = 0; i < n; i++)
                                        {
                                            Console.WriteLine("Nhap thong tin cong nhan thu {0}: ", i + 1);
                                            qlcb.themCB(out cb[i]);
                                            Console.Write("Cap bac (1-10): ");
                                            capBac = int.Parse(Console.ReadLine());
                                            CanBo cn = new CongNhan(cb[i].HoTen, cb[i].GioiTinh, cb[i].DiaChi, cb[i].Tuoi, capBac);
                                            qlcb.them(cn);
                                            Console.WriteLine("=== ========================== === ");
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine("So luong nhan vien: ");
                                        n = int.Parse(Console.ReadLine());
                                        CanBo[] cb = new CanBo[n];
                                        string congViec;
                                        for (int i = 0; i < n; i++)
                                        {
                                            Console.WriteLine("Nhap thong tin nhan vien thu {0}: ", i + 1);
                                            qlcb.themCB(out cb[i]);
                                            Console.Write("Cap bac (1-10): ");
                                            congViec = Console.ReadLine();
                                            CanBo nv = new NhanVien(cb[i].HoTen, cb[i].GioiTinh, cb[i].DiaChi, cb[i].Tuoi, congViec);
                                            qlcb.them(nv);
                                            Console.WriteLine("=== ========================== === ");
                                        }
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("So luong ky su: ");
                                        n = int.Parse(Console.ReadLine());
                                        CanBo[] cb = new CanBo[n];
                                        string nganhDT;
                                        for (int i = 0; i < n; i++)
                                        {
                                            Console.WriteLine("Nhap thong tin ky su thu {0}: ", i + 1);
                                            qlcb.themCB(out cb[i]);
                                            Console.Write("Cap bac (1-10): ");
                                            nganhDT = Console.ReadLine();
                                            CanBo ks = new KySu(cb[i].HoTen, cb[i].GioiTinh, cb[i].DiaChi, cb[i].Tuoi, nganhDT);
                                            qlcb.them(ks);
                                            Console.WriteLine("=== ========================== === ");
                                        }
                                    }
                                    break;
                            }
                        }
                        break;

                    case "b":
                        {
                            Console.WriteLine("=== ========================== === ");
                            Console.Write("Nhap ho ten can bo can tim kiem: ");
                            hten = Console.ReadLine();
                            Console.WriteLine("=== Thong tin can bo tim kiem: ===");
                            qlcb.timKiem(hten);

                        }
                        break;
                    case "c":
                        {
                            Console.WriteLine("=== ========================== === ");
                            Console.WriteLine("=== Thong tin danh sach cac can bo: ===");
                            qlcb.hienThiThongTinCB();
                        }
                        break;
                    case "x":
                        {
                            return;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Nhap sai moi nhap lai");
                        }
                        break;
                }
            }
            
 
            Console.ReadKey();
        }
    }
}
