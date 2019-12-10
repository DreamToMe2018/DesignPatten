using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Strategy
{
    // 現金收費抽象類別
    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}
