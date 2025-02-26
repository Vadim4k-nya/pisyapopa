using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    internal class Teacher : People
    {
        private int experience;
        private int qualification;

        public static int MROT = 22440;

        public Teacher(string name, int age, int experience, int qualification) : base(name, age)
        {
            this.experience = experience;
            this.qualification = qualification;
        }

        public override string GetInfo()
        {
            string qualif = qualification == 1 ? "Кандидат в доктора наук" : "Доктор наук";
            return $"{base.GetInfo()}experience: {experience}\nqualification: {qualif}\nsalary: {GetSalary()}";
        }

        public double GetSalary()
        {
            return MROT + (experience * 500) + (qualification * 900);
        }

    }
}
