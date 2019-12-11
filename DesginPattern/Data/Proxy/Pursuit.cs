using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Proxy
{
    // 追求者類別
    public class Pursuit : IGiveGift
    {
        SchoolGril mm;
        public Pursuit(SchoolGril mm)
        {
            this.mm = mm;
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{mm.Name}送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{mm.Name}送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{mm.Name}送你花");
        }
    }
}
