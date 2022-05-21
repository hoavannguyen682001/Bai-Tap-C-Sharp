using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class NhanVien : CanBo
    {
        private string congViec;

        public NhanVien()
        {

        }

        public NhanVien(string hoTen, string gioiTinh, string diaChi, int tuoi, string congViec) : base(hoTen, gioiTinh, diaChi, tuoi)
        {
            this.congViec = congViec;
        }

        public string CongViec
        {
            get { return congViec; }
            set { congViec = value; }
        }
        public override string ToString()
        {
            return "Nhan Vien: \n" +
                    "Ho Ten: " + HoTen + "\n" +
                    "Gioi Tinh: " + GioiTinh + "\n" +
                    "Dia Chi: " + DiaChi + "\n" +
                    "Tuoi: " + Tuoi + "\n" +
                    "Cong Viec: " + CongViec + "\n";
        }

    }
}
