using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Data.Prototype
{
    public class ResumeV2 : ICloneable
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }

        public WorkExperience WorkExperience { get; set; }


        public ResumeV2(string name)
        {
            this.Name = name;
            this.WorkExperience = new WorkExperience();
        }

        private ResumeV2(WorkExperience workExperience)
        {
            this.WorkExperience = (WorkExperience)workExperience.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.Sex = sex;
            this.Age = age;
        }

        public void SetWorkWxpweience(string timeArea, string company)
        {
            this.WorkExperience.TimeArea = timeArea;
            this.WorkExperience.Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"{this.Name} {this.Sex} {this.Age}");
            Console.WriteLine($"工作經歷 {this.WorkExperience.TimeArea} {this.WorkExperience.Company}");
        }

        public object Clone()
        {
            var resume = new ResumeV2(this.WorkExperience)
            {
                Name = this.Name,
                Sex = this.Sex,
                Age = this.Age
            };
            return resume;
        }
    }
}
