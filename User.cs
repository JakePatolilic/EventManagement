using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement
{
    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public User(string name, string email)
        {
            this.Name = Name;
            this.Email = Email;
        }
    }
}
