using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QLThuVien
{
    public class TapChi:TaiLieu
    {
        private int soPH, thangPH;

        public TapChi()
        {
        }

        public TapChi(int soPH, int thangPH)
        {
            this.soPH = soPH;
            this.thangPH = thangPH;
        }

        public TapChi(string maTL, string nhaXuatBan, int soBanPH,int soPH, int thangPH) : base(maTL, nhaXuatBan, soBanPH)
        {
            this.soPH = soPH;
            this.thangPH = thangPH;
        }

        public int SoPH { get => soPH; set => soPH = value; }
        public int ThangPH { get => thangPH; set => thangPH = value; }

        public override string ToString()
        {
            return "Tap chi: {\n" +
                    "Ma tai lieu: " + MaTL + "\n" +
                    "Nha xuat ban: " + NhaXuatBan + "\n"+
                    "So ban phat hanh: " + SoBanPH + "\n"+
                    "So phat hanh: " + SoPH+ "\n"+
                    "Thang phat hanh: " + ThangPH + "\n"+
                    "}";
        }

    }
}
