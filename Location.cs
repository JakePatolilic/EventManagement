using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    public class Location
    {
            public string? Name { get; private set; }
            public int RentPrice { get; protected set; }
            public Availability Availability;
           // public DateTime Date { get; set; }
            

            public Location(string Name, int RentPrice, Availability Availability)
            {
                this.Name = Name;
                this.RentPrice = RentPrice;
                this.Availability = Availability;
            }
            public override string ToString()
            {
                return "Name of Place: " + Name + "\n" + "Rent Price: " + RentPrice + "\n" + "\n" + "Status: " + Availability;
            }
    }
}
