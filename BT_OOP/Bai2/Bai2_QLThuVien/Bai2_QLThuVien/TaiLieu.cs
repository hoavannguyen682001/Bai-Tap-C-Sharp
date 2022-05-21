using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QLThuVien
{
    public class TaiLieu
    {
        private string maTL, nhaXuatBan;
        private int soBanPH;

        public TaiLieu()
        {
        }

        public TaiLieu(string maTL, string nhaXuatBan, int soBanPH)
        {
            this.maTL = maTL;
            this.nhaXuatBan = nhaXuatBan;
            this.soBanPH = soBanPH;
        }

        public string MaTL { get => maTL; set => maTL = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public int SoBanPH { get => soBanPH; set => soBanPH = value; }


    }
}
