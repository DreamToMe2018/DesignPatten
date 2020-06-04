using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Template
{
    public class ConcreateClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("A方法1實現");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("A方法2實現");
        }
    }
}
