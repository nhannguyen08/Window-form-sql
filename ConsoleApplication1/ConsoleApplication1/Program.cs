using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanAnEntities db = new QuanAnEntities();
            AnSang[] monAn = db.AnSangs.ToArray();
            Console.WriteLine("Bua an sang co {0} mon, bao gom :{1},{2},{3}. ", monAn.Length, monAn[0].TenMon, monAn[1].TenMon, monAn[2].TenMon, monAn[3].TenMon, monAn[4].TenMon);
            for (int i = 0; i < monAn.Length; i++)
                Console.WriteLine("1 dia {0} co gia tien la {1} dong. ", monAn[i].TenMon, monAn[i].GiaTien);

            AnSang monMoi = new AnSang();
            monMoi.TenMon = "Com chien";
            monMoi.GiaTien = 25000;
            db.AnSangs.Add(monMoi);
            db.SaveChanges();

        }
    }
}
