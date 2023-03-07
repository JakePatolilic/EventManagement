using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EventManagement
{
    public class Resort : Location
    {
        public int CottageNum { get; set; }
        public int CottagePrice { get; private set; }
        public int EntranceFee { get; private set; }

        public Resort(string Name, int RentPrice, Availability Availability, int CottageNum, int CottagePrice, int EntranceFee) : base(Name, RentPrice, Availability)
        {
            this.CottageNum = CottageNum;
            this.CottagePrice = CottagePrice;
            this.EntranceFee = EntranceFee;
        }

        public void ComputePrice(Customer c)
        {
            Customer customer = new Customer("", "", 0, 0, 0);
            base.RentPrice = (this.CottageNum * this.CottagePrice) + (this.EntranceFee * customer.TotalPpl);
        }
    }
}
