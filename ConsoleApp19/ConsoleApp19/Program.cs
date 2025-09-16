using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string s2, s1 = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            s2 = Console.ReadLine();
            Console.WriteLine("Ahmat is power, " + s1 + " " + s2 + "!");
        }
    }
}
