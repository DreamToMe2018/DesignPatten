using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Interface
{
    public interface ISimpleFactoryPattern
    {
        int Add(string numberA,string numberB);

        int Sub(string numberA, string numberB);

        int Mul(string numberA, string numberB);

        int Div(string numberA, string numberB);
    }
}
