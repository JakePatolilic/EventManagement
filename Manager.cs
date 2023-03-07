using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    public class Manager : User // organizer
    {
        public string? PhoneNum { get; private set; }
        public List<Event> Events { get; set; }

        public Manager(string Name, string Email, string PhoneNum) : base(Name, Email)
        {
            this.PhoneNum = PhoneNum;
            this.Events = new List<Event>();
        }

        public void AddEvent(Event NewEvent)
        {
            Events.Add(NewEvent);
        }

        public void RemoveEvent(Event CancelEvent) 
        { 
            Events.Remove(CancelEvent);
        }
    }
}
