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
            public int Capacity { get; private set; } // maximum number of people;
            public Availability Availability;
           // public DateTime Date { get; set; }
            

            public Location(string Name, int RentPrice, int Capacity, Availability Availability)
            {
                this.Name = Name;
                this.RentPrice = RentPrice;
                this.Capacity = Capacity;
                this.Availability = Availability;
            }

            public void ComputePrice(Customer c)
            {
                Customer customer = new Customer("", 0, 0, 0);
                this.RentPrice *= customer.RentTime;
            }
            public override string ToString()
            {
                return "Name of Place: " + Name + "\n" + "Rent Price: " + RentPrice + "\n" + "Size: " + Capacity + "\n" + "Status: " + Availability;
            }
    }
}
