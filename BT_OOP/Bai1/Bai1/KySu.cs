using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class KySu : CanBo
    {
        private string nganhDT;

        public KySu()
        {
        }

        public KySu(string hoTen, string gioiTinh, string diaChi, int tuoi, string nganhDT) : base(hoTen, gioiTinh, diaChi, tuoi)
        {
            this.nganhDT = nganhDT;
        }

        public string NganhDT
        {
            get { return nganhDT; }
            set { nganhDT = value; }
        }
        public override string ToString()
        {
            return "Ky Su: \n" +
                    "Ho Ten: " + HoTen + "\n" +
                    "Gioi Tinh: " + GioiTinh + "\n" +
                    "Dia Chi: " + DiaChi + "\n" +
                    "Tuoi: " + Tuoi + "\n" +
                    "Nganh Dao Tao: " + NganhDT + "\n";
        }
    }
}
