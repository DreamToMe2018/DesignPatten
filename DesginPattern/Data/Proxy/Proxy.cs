using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Proxy
{
    public class Proxy : IGiveGift
    {
        Pursuit pursuit;
        public Proxy(SchoolGril gril)
        {
            this.pursuit = new Pursuit(gril);
        }

        public void GiveChocolate()
        {
            this.pursuit.GiveChocolate();
        }

        public void GiveDolls()
        {
            this.pursuit.GiveDolls();
        }

        public void GiveFlowers()
        {
            this.pursuit.GiveFlowers();
        }
    }
}
