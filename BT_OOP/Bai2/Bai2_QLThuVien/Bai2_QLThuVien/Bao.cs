using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QLThuVien
{
    public class Bao:TaiLieu
    {
        private int ngayPH;


        public Bao(string maTL, string nhaXuatBan, int soBanPH, int ngayPH) : base(maTL, nhaXuatBan, soBanPH)
        {
            this.ngayPH = ngayPH;
        }

        public int NgayPH { get => ngayPH; set => ngayPH = value; }

        public override string ToString()
        {
            return "Bao: {\n" +
                    "Ma tai lieu: " + MaTL + "\n" +
                    "Nha xuat ban: " + NhaXuatBan+ "\n" +
                    "So ban phat hanh: " + SoBanPH+ "\n" +
                    "Ngay phat hanh: " + NgayPH+ "\n" +
                    "}";
        }
    }
}
