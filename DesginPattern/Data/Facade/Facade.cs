using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Facade
{
    public class Facade
    {
        SubSystemOne One;
        SubSystemTwo Two;
        SubSystemThree Three;
        SubSystemFour Four;

        public Facade()
        {
            One = new SubSystemOne();
            Two = new SubSystemTwo();
            Three = new SubSystemThree();
            Four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 訪 方法A() ---");
            One.MethodOne();
        }
        public void MethodB()
        {
            Console.WriteLine("\n 訪 方法B() ---");
            Two.MethodTwo();
        }
        public void MethodC()
        {
            Console.WriteLine("\n 訪 方法C() ---");
            Three.MethodThree();
        }
        public void MethodD()
        {
            Console.WriteLine("\n 訪 方法D() ---");
            Four.MethodFour();
        }
    }
}
