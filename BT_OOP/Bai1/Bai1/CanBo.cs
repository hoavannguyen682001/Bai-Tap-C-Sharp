using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CanBo
    {
        private string hoTen, gioiTinh, diaChi;
        private int tuoi;

        public CanBo()
        {
        }

        public CanBo(string hoTen, string gioiTinh, string diaChi, int tuoi)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.tuoi = tuoi;
        }

        public string HoTen
        { 
            get{ return hoTen; } 
            set
            {
                hoTen = value;
            } 
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set
            {
                if(value.Equals("nam") || value.Equals("nu"))
                {
                    gioiTinh = value;
                }
            }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set
            {
                diaChi = value;
            }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set
            {
                if(tuoi >= 0)
                {
                    tuoi = value;
                }
            }
        }

    }
}
