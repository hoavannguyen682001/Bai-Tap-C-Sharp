using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CongNhan : CanBo
    {
        private int capBac;

        public CongNhan()
        {
        }

        public CongNhan(string hoTen, string gioiTinh, string diaChi, int tuoi,int capBac) : base(hoTen, gioiTinh, diaChi, tuoi)
        {
            this.capBac = capBac;
        }

        public int CapBac
        {
            get
            {
                return capBac;
            }
            set
            { 
                if(capBac >0 && capBac <=10)
                    capBac = value;
            }
        }

        public override string ToString()
        {
            return "Cong Nhan: \n" +
                    "Ho Ten: " +HoTen+"\n" +
                    "Gioi Tinh: " + GioiTinh + "\n" +
                    "Dia Chi: " + DiaChi + "\n" +
                    "Tuoi: " + Tuoi + "\n" +
                    "Cap Bac: " + CapBac + "\n";
        }
    }
}
