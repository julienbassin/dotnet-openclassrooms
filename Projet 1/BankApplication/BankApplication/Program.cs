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
            // create client with client class
            Client client1 = new Client("alice", "toto", "5 street" , "New York", 92110);
            Client client2 = new Client("jon", "titi", "10 Avenue", "Los Angeles",78390);
            Console.WriteLine($"{client1.ToString()}");
            Console.WriteLine($"{client2.ToString()}");

            int numberOfAccounts = 0;

            client1.WithDrawChecking();

            var account = new Account();

            // ask how many accounts do you want to create fro each client ?
            Console.WriteLine("How many accounts do you want create ?");
            Int32.TryParse(Console.ReadLine(), out numberOfAccounts);
            Account[] accounts = new Account[numberOfAccounts];
            for (int i = 0; i < accounts.Length-1; i++)
            {
                accounts[i] = account;
            }
            

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
