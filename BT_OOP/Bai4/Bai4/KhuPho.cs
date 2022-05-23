using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class KhuPho
    {
        private List<HoGiaDinh> hoGiaDinhs;

        public KhuPho()
        {
            this.hoGiaDinhs = new List<HoGiaDinh>();

        }

        public List<HoGiaDinh> HoGiaDinhs { get => hoGiaDinhs; set => hoGiaDinhs = value; }

        public void them(HoGiaDinh hoGiaDinh)
        {
            this.hoGiaDinhs.Add(hoGiaDinh);
        }

        public bool kiemTraCMNDKP(int cmnd)
        {
            foreach(var hoGD in HoGiaDinhs)
            {
                foreach(var nguoi in hoGD.ThanhVien)
                {
                    if (nguoi.Cmnd == cmnd)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine("so ho gia dinh " + hoGiaDinhs.Count);
            hoGiaDinhs.ForEach(delegate (HoGiaDinh item)
            {
                item.Display("all");
            });
        }
        public void timKiem(string cmnd)
        {
            foreach (HoGiaDinh hoGD in hoGiaDinhs)
            {
                if (hoGD.ThanhVien.Find(x => x.Cmnd.ToString().Equals(cmnd)) != null)
                {
                    hoGD.Display(cmnd);
                }
                else
                {
                    Console.WriteLine("Khong tim thay");
                }

            }
        }
    }
}
