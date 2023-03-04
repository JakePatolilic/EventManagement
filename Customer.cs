using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    internal class Customer
    {
        public string? Name { get; set; }
        public int TotalPpl { get; set; }
        public int Money { get; set; }
        public int RentTime { get; set; }

        public Customer(string Name, int TotalPpl, int Money, int RentTime)
        {
            this.Name = Name;
            this.TotalPpl = TotalPpl;
            this.Money = Money;
            this.RentTime = RentTime;
        }
    }
}
