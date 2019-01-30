using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Owner
    {
        private string name;
        private string address;
        private ulong phone;
        public Owner() { }
        public Owner(string n, string addss, ulong phn)
        {
            name = n;
            address = addss;
            phone = phn;
        }

        public String getName()
        {
            return name;
        }
        public String getAddress()
        {
            return address;
        }
        public ulong getPhone()
        {
            return phone;
        }

    }
}
