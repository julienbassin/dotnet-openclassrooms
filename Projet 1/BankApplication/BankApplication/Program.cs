using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAccounts = 0;
            int numberOfClients = 0;
            Console.WriteLine("How many clients do you want to create ?");
            Int32.TryParse(Console.ReadLine(), out numberOfClients);
            List<Client> client = new List<Client>();

            for (int i = 0; i < numberOfClients; i++)
            {
                client.Add(new Client("", ""));
            }
            // create client with client class
            Client client1 = new Client("alice", "toto", "5 street" , "New York", 92110);
            Client client2 = new Client("jon", "titi", "10 Avenue", "Los Angeles",78390);

            Console.WriteLine("How many accounts do you want create ?");
            Int32.TryParse(Console.ReadLine(), out numberOfAccounts);
            // ask how many accounts do you want to create fro each client ? 
            for (int i = 0; i < numberOfAccounts; i++)
            {
                var account = new Account();
                client1.AccountList().Add(account);

                //methode un account qui appartient à un client
            }
            
            //accounts[nextIndex] = account;

            // client can create 1 ou 2 or many account per user

            // client can get account number

            //Client's choice
            var input = "";
            do
            {
                Console.WriteLine("\t\t\t Banking Application");
                Console.WriteLine("\t1> GetBalance");
                Console.WriteLine("\t2> Deposit");
                Console.WriteLine("\t3> Withdraw");
                Console.WriteLine("\t4> Modify");
                Console.WriteLine("\t5> Display");
                Console.WriteLine("\t6> Exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        Console.WriteLine("Goodbye !");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Exit the Application!!!");
                        break;
                }
            } while (input == "6");
        }
    }
}
