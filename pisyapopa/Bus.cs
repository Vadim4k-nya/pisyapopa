using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    public class Bus : PublicTransport
    {
        private double fuelCapacity;

        public Bus(int number, int capacity, double speed, double fuelCapacity) : base(number, capacity, speed)
        {
            this.fuelCapacity = fuelCapacity;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}fuelCapacity: {fuelCapacity}\n";
        }

        public double FuelCalculation()
        {
            return fuelCapacity * 25 / 20;
        }
    }
}
