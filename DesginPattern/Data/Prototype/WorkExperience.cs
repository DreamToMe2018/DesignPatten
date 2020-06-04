using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Prototype
{
    public class WorkExperience : ICloneable
    {
        public string TimeArea { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
