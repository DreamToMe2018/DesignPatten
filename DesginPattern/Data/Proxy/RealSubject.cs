using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Proxy
{
    public class RealSubject : Suject
    {
        public override void Request()
        {
            Console.WriteLine("真實的請求");
        }
    }
}
