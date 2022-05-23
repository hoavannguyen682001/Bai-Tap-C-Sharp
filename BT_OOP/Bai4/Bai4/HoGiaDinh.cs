using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class HoGiaDinh
    {
        private List<Nguoi> thanhVien;
        private string  soNha;


        public HoGiaDinh()
        {
            this.thanhVien = new List<Nguoi>();

        }
        public void themThanhVien(Nguoi nguoi)
        {
            this.thanhVien.Add(nguoi);
        }

        public HoGiaDinh(List<Nguoi> thanhVien, string soNha)
        {
            this.thanhVien = thanhVien;
            this.soNha = soNha;
        }


        public string SoNha { get => soNha; set => soNha = value; }
        public List<Nguoi> ThanhVien { get => thanhVien; set => thanhVien = value; }

        public bool kiemTraCMND(int cmnd)
        {
            foreach(var nguoi in ThanhVien)
            {
                if (nguoi.Cmnd == cmnd)
                {
                    return true;
                }
            }
            return false;
        }

        public void Display(string typeDisplay)
        {

            Console.WriteLine($"address: {soNha}");

            thanhVien.ForEach(delegate (Nguoi item)
            {
                if (typeDisplay.Equals("all"))
                {
                    item.Display();

                }
                else
                {
                    if (item.Cmnd.ToString().Equals(typeDisplay))
                    {
                        item.Display();
                    }
                }
            });
        }
    }
}
