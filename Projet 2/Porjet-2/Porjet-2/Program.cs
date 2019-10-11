using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porjet_2
{
    
    class Program
    {
        public static string AskForUrl()
        {
            Console.WriteLine("Please enter a valid URL");
            string url = Console.ReadLine();
            return url;
        }
        static void Main(string[] args)
        {
            string urlString = String.Empty;
            int numberOfArguments = 0;

            if (args == null)
                numberOfArguments = 0;
            else
                numberOfArguments = args.Length;
            switch (numberOfArguments)
            {
                case 0:
                    urlString = AskForUrl();
                    break;
                case 1:
                    urlString = args[0];
                    break;
                default:
                    Console.WriteLine("Please run the program with the desired URL or no argument at all");
                    Environment.Exit(-1);
                    break;
            }

            Console.WriteLine("Checking URL " + urlString);
            if (Uri.IsWellFormedUriString(urlString, UriKind.Absolute))
            {
                Console.WriteLine(urlString + " is a well-formed URL");
            }
            else
            {
                Console.WriteLine(urlString + " is not a well-formed URL");
            }
        }

        
    }
}
