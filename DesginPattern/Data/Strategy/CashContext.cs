using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Strategy
{
    public class CashContext
    {
        public CashSuper super;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收費":
                    super = new CashNormal();
                    break;
                case "滿300送100":
                    // 將實體化具體策略的過程由用戶端轉移到Context類別中。簡單工廠的應用。
                    super = new CashReturn("300", "100");
                    break;
                case "打8折":
                    super = new CashRebate("0.8");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return super.AcceptCash(money);
        }
    }
}
