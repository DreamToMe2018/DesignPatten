using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Decorator
{
    // 具體服飾類別(ConcreteDecorator)
    public class BusinessSuit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("西裝");
            base.Show();
        }
    }
}
