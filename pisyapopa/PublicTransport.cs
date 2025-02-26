using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pisyapopa
{
    public class PublicTransport
    {
        private int number;
        private int capacity;
        private double speed;

        public PublicTransport(int number, int capacity, double speed)
        {
            this.number = number;
            this.capacity = capacity;
            this.speed = speed;
        }

        public virtual string GetInfo()
        {
            return $"number: {number}\ncapacity: {capacity}\nspeed: {speed}\n";
        }
    }
}
