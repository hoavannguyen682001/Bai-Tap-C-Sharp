using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            KhuPho kp = new KhuPho();
            HoGiaDinh hoGD = new HoGiaDinh();
            int soHoGD;
            Console.WriteLine("Nhap so luong ho gia dinh: ");
            soHoGD = Int32.Parse(Console.ReadLine());

            for(int i  = 0; i < soHoGD; i++)
            {
                Console.Write("Nhap dia chi ho gia dinh thu {0}: ", i + 1);
                string address;
                address = Console.ReadLine();

                Console.Write("So luong thanh vien trong ho gia dinh: ");
                int n = Int32.Parse(Console.ReadLine());

                for(int j = 0; j < n; j++)
                {
                    Console.WriteLine("Nhap thong tin thanh vien thu {0}: ", j + 1);
                    Console.Write("Ho va ten: ");
                    string hoten = Console.ReadLine();
                    Console.Write("Tuoi: ");
                    int tuoi = Int32.Parse(Console.ReadLine());
                    Console.Write("Nghe nghiep: ");
                    string jobs = Console.ReadLine();
                    int cmnd = -1;
                    do
                    {
                        if(hoGD.kiemTraCMND(cmnd) || kp.kiemTraCMNDKP(cmnd))
                        {
                            Console.WriteLine("Số CMND: {cmnd} đã tồn tại!\nVui Lòng nhập lại.");
                        }
                        Console.Write("CMND: ");
                        cmnd = Int32.Parse(Console.ReadLine());
                    } while (hoGD.kiemTraCMND(cmnd) || kp.kiemTraCMNDKP(cmnd));
                    
                    hoGD.themThanhVien(new Nguoi(hoten, jobs, tuoi, cmnd));
                }
                kp.them(new HoGiaDinh(hoGD.ThanhVien, address));
            }
            kp.Display();
            //kp.timKiem("1");
            Console.ReadKey();
        }
    }
}
