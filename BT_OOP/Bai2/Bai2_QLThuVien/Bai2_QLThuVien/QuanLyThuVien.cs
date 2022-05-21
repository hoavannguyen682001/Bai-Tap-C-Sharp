using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QLThuVien
{
    public class QuanLyThuVien
    {
        List<TaiLieu> listTL;

        public QuanLyThuVien()
        {
            this.listTL = new List<TaiLieu>();
        }
        public void them(TaiLieu tl)
        { 
            this.listTL.Add(tl);
        }
        public void themTaiLieu(out TaiLieu taiLieu)
        {
            taiLieu = new TaiLieu();
            Console.Write("Ma tai lieu: ");
            taiLieu.MaTL = Console.ReadLine();
            Console.Write("Nha xuat ban: ");
            taiLieu.NhaXuatBan = Console.ReadLine();
            Console.Write("So ban phat hanh: ");
            taiLieu.SoBanPH = Int32.Parse(Console.ReadLine());
        }

        public void hienThiThongTin()
        {
            foreach(var tl in listTL)
            {
                Console.WriteLine(tl);
            }
        }

        public bool kiemTraMaTL(string maTL)
        {
            if (this.listTL.Count() == 0)
            {
                return false;
            }
            return this.listTL.Exists(x => x.MaTL == maTL);
        }

        public void xoaTaiLieu(string maTL)
        {
            this.listTL.RemoveAt(listTL.FindIndex(doc => doc.MaTL.Equals(maTL)));
        }

        public void timKiem(string maTL, string theLoai)
        {
            foreach(var tl in listTL)
            {
                string loai = tl.GetType().ToString();
                if(tl.MaTL.Equals(maTL) && loai.Contains(theLoai))
                {
                    Console.WriteLine(tl);
                }
                else
                {
                    Console.WriteLine("ko tim thay");
                }
            }
        }
    }
}
