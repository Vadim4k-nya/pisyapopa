using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    public class Student : People
    {
        private int course;
        private int group;

        public Student (string name, int age, int course, int group) :base(name, age)
        {
            this.course = course;
            this.group = group;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}course: {course}\ngroup: {group}";
        }
    }
}
