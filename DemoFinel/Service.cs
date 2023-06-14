using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinel
{
    public static class Service
    {
        static List<DongVat> dongVats = new List<DongVat>();

        public static void nhap()
        {
            do
            {
                DongVat dv = new DongVat();
                dv.nhapThongTin();
                dongVats.Add(dv);

                Console.WriteLine("Tiep tuc? (y)");
                if (Console.ReadLine() == "y")
                {

                }
                else
                {
                    break;
                }

            } while (true);
        }

        public static void xuat()
        {
            foreach(DongVat dv in dongVats)
            {
                dv.ShowThongTin();
            }
        }

        public static void FindByID()
        {
            Console.WriteLine("Nhap ID muon tim");
            int id = int.Parse(Console.ReadLine());
            foreach (DongVat dv in dongVats) 
            {
                if(dv.getMADV() == id)
                {
                    dv.ShowThongTin();
                }
            }
        }

        public static void Sortting()
        {
            dongVats =  dongVats.OrderBy(dv=>dv.getMADV()).ToList();
            Console.WriteLine("Danh sach dong vat da duoc sap xep");
        }

        public static void addDemoData()
        {
            DongVat dv1 = new DongVat(1,"Meo","Den", "Tren can");
            DongVat dv2 = new DongVat(2,"Vet" ,"Do", "Trong rung");
            DongVat dv3 = new DongVat(3, "Cho" ,"Vang", "Tren can");
            dongVats.Add(dv1);
            dongVats.Add(dv3);
            dongVats.Add(dv2);
            
        }


    }
}
