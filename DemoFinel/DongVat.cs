using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinel
{
    internal class DongVat
    {
        protected int maDV;
        protected string loai;
        protected string mauSac;
        protected string moiTruongSong;
        public DongVat()
        {
        }

        public DongVat(int maDV, string loai, string mauSac, string moiTruongSong)
        {
            this.maDV = maDV;
            this.loai = loai;
            this.mauSac = mauSac;
            this.moiTruongSong = moiTruongSong;
        }

        public int getMADV()
        {
            return this.maDV;
        }
        public string getLoai()
        {
            return this.loai;
        }
        public virtual void ShowThongTin()
        {
            Console.WriteLine();
            Console.WriteLine("Ma Dong Vat: " + this.maDV);
            Console.WriteLine("Loai: " + this.loai);
            Console.WriteLine("Mau Sac: " + this.mauSac);
            Console.WriteLine("Moi truong song: " + this.moiTruongSong);
        }

        public virtual void nhapThongTin()
        {
            Console.Write("Ma DV:");
            this.maDV = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Loai:");
            this.loai = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Mau Sac:");
            this.mauSac = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Moi truong song:");
            this.moiTruongSong = Console.ReadLine();

        }
    }
}
