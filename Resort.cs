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

        public Resort(string Name, int RentPrice, int Capacity, Availability Availability, int CottageNum, int CottagePrice) : base(Name, RentPrice, Capacity, Availability)
        {
            this.CottageNum = CottageNum;
            this.CottagePrice = CottagePrice;
        }

        public void ComputePrice()
        {
            base.RentPrice = this.CottageNum * this.CottagePrice;
        }
    }
}
