using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QLThuVien
{
    public class Sach : TaiLieu
    {
        private string tenTG;
        private int soTrang;

        public Sach()
        {
        }

        public Sach(string tenTG, int soTrang)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }

        public Sach(string maTL, string nhaXuatBan, int soBanPH,string tenTG, int soTrang) : base(maTL, nhaXuatBan, soBanPH)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }

        public string TenTG { get => tenTG; set => tenTG = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }

        public override string ToString()
        {
            return "Sach: {\n" +
                    "Ma tai lieu:" + MaTL + "\n"+
                    "Nha xuat ban: " + NhaXuatBan + "\n" +
                    "So ban phat hanh: " + SoBanPH + "\n" +
                    "Ten tac gia: " + TenTG + "\n" +
                    "So trang: " + SoTrang + "\n" +
                    "}";
        }
    }
}
