using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.SimpleFactory
{
    public class SimpleFactoryPattern : ISimpleFactoryPattern
    {
        public int Add(string numberA, string numberB)
        {
            return Convert.ToInt32(numberA) + Convert.ToInt32(numberB);
        }

        public int Div(string numberA, string numberB)
        {
            return Convert.ToInt32(numberA) - Convert.ToInt32(numberB);
        }

        public int Mul(string numberA, string numberB)
        {
            return Convert.ToInt32(numberA) * Convert.ToInt32(numberB);
        }

        public int Sub(string numberA, string numberB)
        {
            return Convert.ToInt32(numberA) / Convert.ToInt32(numberB);
        }
    }
}
