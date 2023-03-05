using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    public class Venue : Location
    {
        public int RentFee { get; private set; }
        public int Capacity { get; private set; }

        public Venue(string Name, int RentPrice, Availability Availability, int RentFee ,int Capacity) : base(Name, RentPrice, Availability)
        {
            this.RentFee = RentFee;
            this.Capacity = Capacity;
        }
    }
}
