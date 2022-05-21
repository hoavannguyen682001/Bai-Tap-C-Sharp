using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QLThuVien
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            QuanLyThuVien qltv = new QuanLyThuVien();
            
            while (true)
            {
                Console.WriteLine("1-Them tai lieu");
                Console.WriteLine("2-Xoa tai lieu");
                Console.WriteLine("3-Hien thi thong tin tai lieu");
                Console.WriteLine("4-Tim kiem tai lieu theo loai: Sach, Bao, Tap Chi");
                Console.WriteLine("0-Thoat");
                x = Int32.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            themTaiLieu(qltv);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Nhap ma tai lieu:");
                            string maTL = Console.ReadLine();
                            qltv.xoaTaiLieu(maTL);
                        }
                        break;
                    case 3:
                        {
                            qltv.hienThiThongTin();
                        }
                        break;
                    case 4:
                        {
                            timKiemTaiLieu(qltv);
                        }
                        break;
                    case 0:
                        return;
                    default:
                        {
                               
                        }
                        break;
                }
            }
            
            
            Console.ReadKey();
        }
        public static void themTaiLieu(QuanLyThuVien qltv)
        {
            int chonTL;
            TaiLieu tl;
            Console.WriteLine("1-Them sach");
            Console.WriteLine("2-Them bao");
            Console.WriteLine("3-Them tap chi");
            Console.WriteLine("0 - Quay lai");

            chonTL = Int32.Parse(Console.ReadLine());

            switch (chonTL)
            {
                case 1:
                    {
                        
                        //tl = new TaiLieu();
                        do
                        {
                            Console.WriteLine("Nhap tai lieu: ");
                            qltv.themTaiLieu(out tl);
                            if (qltv.kiemTraMaTL(tl.MaTL))
                            {
                                Console.WriteLine("Trung ma tai lieu!");
                                Console.WriteLine("Moi nhap lai!");
                            }
                            
                           
                        } while (qltv.kiemTraMaTL(tl.MaTL));

                        Console.Write("Ten tac gia: ");
                        string tenTG = Console.ReadLine();
                        Console.Write("So trang: ");
                        int soTrang = Int32.Parse(Console.ReadLine());

                        TaiLieu sach = new Sach(tl.MaTL, tl.NhaXuatBan, tl.SoBanPH, tenTG, soTrang);
                        qltv.them(sach);
                    }
                    break;
                case 2:
                    {
                        
                        //tl = new TaiLieu();
                        do {
                            Console.WriteLine("Nhap tai lieu: ");
                            qltv.themTaiLieu(out tl);
                            if (qltv.kiemTraMaTL(tl.MaTL))
                            {
                                Console.WriteLine("Trung ma tai lieu!");
                                Console.WriteLine("Moi nhap lai!");
                            }

                        } while (qltv.kiemTraMaTL(tl.MaTL)==true) ;
                        Console.Write("Ngay phat hanh: ");
                        int ngayPH = Int32.Parse(Console.ReadLine());

                        TaiLieu bao = new Bao(tl.MaTL, tl.NhaXuatBan, tl.SoBanPH, ngayPH);

                        qltv.them(bao);

                        qltv.hienThiThongTin();
                    }
                    break;
                case 3:
                    {
                        
                        //tl = new TaiLieu();
                        do
                        {
                            Console.WriteLine("Nhap tai lieu: ");
                            qltv.themTaiLieu(out tl);
                            if (qltv.kiemTraMaTL(tl.MaTL))
                            {
                                Console.WriteLine("Trung ma tai lieu!");
                                Console.WriteLine("Moi nhap lai!");
                            }
                        } while (qltv.kiemTraMaTL(tl.MaTL)==true);

                        Console.Write("So phat hanh: ");
                        int soPH = Int32.Parse(Console.ReadLine());
                        Console.Write("Thang phat hanh: ");
                        int thangPH = Int32.Parse(Console.ReadLine());

                        TaiLieu tapChi = new TapChi(tl.MaTL, tl.NhaXuatBan, tl.SoBanPH, soPH, thangPH);

                        qltv.them(tapChi);

                        qltv.hienThiThongTin();
                    }
                    break;
                case 0:
                    return;
            }
        }

        public static void timKiemTaiLieu(QuanLyThuVien qltv)
        {
            int x;
            string maTL;
            Console.WriteLine("1-Sach");
            Console.WriteLine("2-Bao");
            Console.WriteLine("3-Tap Chi");
            Console.WriteLine("Chon the loai can tim kiem");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma tai lieu");
            maTL = Console.ReadLine();
            switch (x)
            {
                case 1:
                    {
                        qltv.timKiem(maTL, "Sach");
                    }
                    break;
                case 2:
                    {
                        qltv.timKiem(maTL, "Bao");
                    }
                    break;
                case 3:
                    {
                        qltv.timKiem(maTL, "TapChi");
                    }
                    break;
                case 0:
                    return;
            }
            
        }
    }
}
