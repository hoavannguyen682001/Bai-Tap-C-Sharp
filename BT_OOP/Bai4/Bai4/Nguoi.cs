using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Nguoi
    {
        private string hoTen,  ngheNghiep;
        private int tuoi, cmnd;

        public Nguoi()
        {
        }

        public Nguoi(string hoTen, string ngheNghiep, int tuoi, int cmnd)
        {
            this.hoTen = hoTen;
            this.ngheNghiep = ngheNghiep;
            this.tuoi = tuoi;
            this.cmnd = cmnd;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }

        public void Display()
        {
            Console.WriteLine(
                "Person{" +
                "Ho va ten = '" + hoTen + '\'' +
                ", Tuoi = " + tuoi +
                ", Nghe nghiep = '" + ngheNghiep + '\'' +
                ", CMND = '" + cmnd + '\'' +
                '}'
                );
        }
    }
}
