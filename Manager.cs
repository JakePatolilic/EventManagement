using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    public class Manager // organizer
    {
        public string? Name { get; private set; }
        public string? Email { get; private set; }
        public string? PhoneNum { get; private set; }

        public Manager(string Name, string Email, string PhoneNum)
        {
            this.Name = Name;
            this.Email = Email;
            this.PhoneNum = PhoneNum;
        }
    }
}
