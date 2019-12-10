using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Strategy
{
    // 紅利收費子類別
    public class CashReturn : CashSuper
    {
        // 紅利收費 初始化時要輸入紅利條件和紅利值例如滿300送100;
        // 紅利條件
        public double moneyCondition = 0.0d;
        // 紅利值
        public double moneyReturn = 0.0d;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;

            return result;
        }
    }
}
