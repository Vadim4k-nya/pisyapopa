using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    public class Trolleybus : PublicTransport
    {
        private double acumCapacity;

        public Trolleybus(int number, int capacity, double speed, double acumCapacity) : base(number, capacity, speed)
        {
            this.acumCapacity = acumCapacity;
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}acumCapacity: {acumCapacity}\n";
        }

        public double AcumCalculation()
        {
            return acumCapacity * 70 / 200;
        }
    }
}
