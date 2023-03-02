using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegaxDemoProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();

            Console.WriteLine("Enter your First Name: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name!");
            }
            Console.Read();
        }
    }
}
