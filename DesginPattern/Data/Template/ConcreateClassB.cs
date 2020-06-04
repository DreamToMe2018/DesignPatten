using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Template
{
    public class ConcreateClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("B方法1實現");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("B方法2實現");
        }
    }
}
