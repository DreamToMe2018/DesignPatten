using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Decorator
{
    // 具體服飾類別(ConcreteDecorator)
    public class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("球鞋");
            base.Show();
        }
    }
}
