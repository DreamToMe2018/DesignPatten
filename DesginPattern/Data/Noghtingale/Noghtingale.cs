using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Noghtingale
{
    // 南丁格爾
    public class Noghtingale
    {
        public void Sweep()
        {
            Console.WriteLine("掃地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine("買米");
        }

        public static Noghtingale CreateNoghtingale(string type)
        {
            Noghtingale result = null;
            switch (type)
            {
                case "學南丁格爾的大學生":
                    result = new Undergraduate();
                    break;
                case "社區義工":
                    result = new Volunteer();
                    break;
            }

            return result;
        }
    }
}
