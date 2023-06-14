using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFinel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.addDemoData();

            Menu();


            Console.ReadLine();

        }

        static void Menu()
        {
            do
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1: Nhap danh sach dong vat");
                Console.WriteLine("2: Xuat danh sach dong vat");
                Console.WriteLine("3: Tim dong vat theo id");
                Console.WriteLine("4: Sap xep dong vat");
                Console.WriteLine("5: Ke thua");
                Console.WriteLine("6: Thoat");
                string chose = Console.ReadLine();
                
                if(chose == "6")
                {
                    break;
                }

                switch (chose)
                {
                    case "1":
                        {
                            Service.nhap();
                            break;
                        }
                    case "2":
                        {
                            Service.xuat();
                            break;
                        }
                    case "3":
                        {
                            Service.FindByID();
                            break;
                        }
                    case "4":
                        {
                            Service.Sortting();
                            break;
                        }
                    case "5":
                        {
                            KeThua();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Khong co chuc nang");
                            break;
                        }

                }


            } while (true);
        }

        static void KeThua()
        {
            DongVatCoCanh dvcc = new DongVatCoCanh();
            dvcc.nhapThongTin();
            dvcc.ShowThongTin();
        }
    }
}
