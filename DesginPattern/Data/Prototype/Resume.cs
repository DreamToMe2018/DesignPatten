using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Prototype
{
    public class Resume : ICloneable
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string TimeArea { get; set; }
        public string Company { get; set; }

        public Resume(string name)
        {
            this.Name = name;
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.Sex = sex;
            this.Age = age;
        }

        public void SetWorkWxpweience(string timeArea, string company)
        {
            this.TimeArea = timeArea;
            this.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{this.Name} {this.Sex} {this.Age}");
            Console.WriteLine($"工作經歷 {this.TimeArea} {Company}");
        }

        public object Clone()
        {
            // 內建的方法
            return (object)this.MemberwiseClone();
        }
    }
}
