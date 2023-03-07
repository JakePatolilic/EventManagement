using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    public class Event
    {
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? Location { get; set; }
        public int Capacity { get; set; }
        public int Cost { get; set; }

        public Event(string Name, DateTime Date, string Location, int Capacity, int Cost)
        {
            this.Name = Name;
            this.Date = Date;
            this.Location = Location;
            this.Capacity = Capacity;
            this.Cost = Cost;
        }

        public override string ToString() 
        {
            return "Event: " + Name + "\n" + "When: " + Date + "\n" + "Where: " + Location;
        }
    }
}
