using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, contact;
            int age;
            Console.Write("Please enter your name \t\t: \t");
            name = Console.ReadLine();
            Console.Write("Please enter your age \t\t: \t");
            age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Please enter your address \t: \t");
            address = Console.ReadLine();
            Console.Write("Please enter your contact \t: \t");
            contact = Console.ReadLine();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t My Information");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("My Name is \t: "+ name);
            Console.WriteLine("My Age is \t: "+ age);
            Console.WriteLine("My Address is \t: "+ address);
            Console.WriteLine("My Contact is \t: "+ contact);
            Console.ReadKey();

        }
    }
}
