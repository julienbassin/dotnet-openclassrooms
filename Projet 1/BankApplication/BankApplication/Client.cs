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
<<<<<<< HEAD
        }

        public List <Account> clientlist(int acountid)
        {

            List<Account> list = new List<Account>();

            var Acountlist = list.Add(this.AccountID);

            return Acountlist;
        }
=======
        }      
>>>>>>> 4aa9a8ab09be88623c907307f2854b8d9475304e

        public Client(string ClientName, string ClientLastName, string ClientAddress, string ClientCity, int ClientZipCode)
        {
            Name = ClientName;
            LastName = ClientLastName;
            Address = ClientAddress;
            City = ClientCity;
            ZipCode = ClientZipCode;            
        }

        //methode qui retourne mes comptes superieur à 0 ou inférieur à 0
        public List<Account> AccountList()
        {

            List<Account> list = new List<Account>();

            var Acountlist = list.ToList();

            return Acountlist;
        }

        public override string ToString()
        {
            return $"The client {Name} has been created".ToString();
        }
    }
}
