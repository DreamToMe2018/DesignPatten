using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Data.Decorator
{
    // Person類別(ConcreteComponent)
    public class Person
    {
        public Person() { }

        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"裝扮的{name}");
        }
    }
}
