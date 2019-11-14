using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var md = new OOPCSEntities();
            Expenditure[] list = md.Expenditures.ToArray();
            
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].id + " " + list[i].Note +" "+list[i].Price+ " " + list[i].Date);
                
                sum += list[i].Price;
            }
            Console.WriteLine("Tong gia tien la :{0}đ", sum);

        }
    }
}
