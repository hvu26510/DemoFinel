using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinel
{
    internal class DongVatCoCanh : DongVat
    {
        private bool bay;

        public DongVatCoCanh()
        {
        }

        public DongVatCoCanh(int maDV, string loai, string mauSac, string moiTruongSong, bool bay) 
            : base(maDV, loai, mauSac, moiTruongSong)
        {
            this.bay = bay;
        }

        public override void ShowThongTin()
        {
            base.ShowThongTin();

            if (bay)
            {
                Console.WriteLine("Co the bay");
            }
            else
            {
                Console.WriteLine("Khong the bay");
            }
        }

        public override void nhapThongTin()
        {
            base.nhapThongTin();

            Console.WriteLine("Co the bay khong? (y/other)");
            if (Console.ReadLine() == "y")
            {
                this.bay = true;
            }
            else
            {
                this.bay = false;
            }
        }
    }
}
