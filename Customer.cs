using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    public class Customer : User
    {
        public int TotalPpl { get; set; }
        public int Money { get; set; }
        public int RentTime { get; set; }
        public Manager? managers { get; set; }

        public Customer(string Name, string Email, int TotalPpl, int Money, int RentTime): base(Name, Email)
        {
            this.TotalPpl = TotalPpl;
            this.Money = Money;
            this.RentTime = RentTime;
            this.managers = managers;
        }
    }
}
