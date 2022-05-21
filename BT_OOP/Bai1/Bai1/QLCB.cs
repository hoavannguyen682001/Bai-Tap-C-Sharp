using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class QLCB
    {
        private List<CanBo> canBo;

        public QLCB()
        {
            this.canBo = new List<CanBo>();
        }

        public void them(CanBo cb)
        {
            this.canBo.Add(cb);
        }

        public void themCB(out CanBo cb)
        {
            cb = new CanBo();
            Console.Write("Ten can bo: ");
            cb.HoTen = Console.ReadLine();
            
            Console.Write("Gioi tinh: ");
            cb.GioiTinh = Console.ReadLine();
            
            Console.Write("Dia chi: ");
            cb.DiaChi = Console.ReadLine();
            
            Console.Write("Tuoi: ");
            cb.Tuoi = int.Parse(Console.ReadLine());
        }

        public void timKiem(string hten)
        {
            foreach(var cb in canBo)
            {
                if (cb.HoTen.Contains(hten))
                {
                    Console.WriteLine(cb);
                }
            }
        }

        public void hienThiThongTinCB()
        {
            foreach(var cb in canBo)
            {
                //Console.WriteLine(cb.ToString());
                Console.WriteLine(cb);
            }
        }
    }
}
