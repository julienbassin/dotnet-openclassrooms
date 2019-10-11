using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyday1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            int age;
            Console.WriteLine("Plase enter your name ?");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your age ");
            age = Convert.ToInt32( Console.ReadLine()); // int.parse(  )

            Console.WriteLine("Your name is " + fname); // string concatination 
            Console.WriteLine("Your gae is " + age);

            Console.ReadKey(); // to prevent window close untill user use any key 

               
                


        }
    }
    
}
