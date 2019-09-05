using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Strategy
{
    // 打折收費類別
    // 需要初始化折扣率，例如8折舊是0.8
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
