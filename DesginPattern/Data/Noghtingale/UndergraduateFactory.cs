using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Noghtingale
{
    public class UndergraduateFactory : IFactory
    {
        public Noghtingale CreateNoghtingale(string type)
        {
            return new Undergraduate();
        }
    }
}
