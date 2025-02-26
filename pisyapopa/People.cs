using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    public class People
    {
        private string name;
        private int age;

        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string GetInfo()
        {
            return $"name: {name}\nage: {age}\n";
        }
    }
}
