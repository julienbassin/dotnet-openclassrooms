using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Client
    {
        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string _Address { get; set; }
        public string _City { get; set; }
        public int _ZipCode { get; set; }

        public Client(string Name, string LastName)
        {
            _Name = Name;
            _LastName = LastName;
        }

        public Client(string Name, string LastName, string Address, string City, int ZipCode)
        {
            _Name = Name;
            _LastName = LastName;
            _Address = Address;
            _City = City;
            _ZipCode = ZipCode;            
        }

        public override string ToString()
        {
            return $"The client {_Name} has been created".ToString();
        }
    }
}
