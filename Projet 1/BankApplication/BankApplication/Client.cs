using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Client
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public int AccountID { get; set; } = 3;

        public Client(string ClientName, string LastClientName)
        {
            Name = ClientName;
            LastName = LastClientName;
        }

        public List <Account> clientlist(int acountid)
        {

            List<Account> list = new List<Account>();

            var Acountlist = list.Add(this.AccountID);

            return Acountlist;
        }

        public Client(string ClientName, string ClientLastName, string ClientAddress, string ClientCity, int ClientZipCode)
        {
            Name = ClientName;
            LastName = ClientLastName;
            Address = ClientAddress;
            City = ClientCity;
            ZipCode = ClientZipCode;            
        }

        public override string ToString()
        {
            return $"The client {Name} has been created".ToString();
        }
    }
}
