﻿using System;
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
            Client client1 = new Client("alice", "toto", "5 street" , "New York", "92110");
            Client client2 = new Client("jon", "titi", "10 Avenue", "Los Angeles", "78390");

            int _nextIndex = 0;
            int _numberOfAccounts = 0;

            // ask how many accounts do you want to create fro each client ? 
            
            Account[] _accounts = new Account[_numberOfAccounts];

            //_accounts[_nextIndex] = 

            // client can create 1 ou 2 or many account per user

            // client can get account number

            //Client's choice
            var input = Console.ReadLine();
            do
            {
                Console.WriteLine("\t\t\t Banking Application");
                Console.WriteLine("\t1> GetBalance");
                Console.WriteLine("\t2> Deposit");
                Console.WriteLine("\t3> Withdraw");
                Console.WriteLine("\t4> Modify");
                Console.WriteLine("\t5> Display");
                Console.WriteLine("\t6> Exit");
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