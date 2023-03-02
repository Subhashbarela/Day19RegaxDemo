using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegaxDemoConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patterns pattern = new Patterns();

            Console.WriteLine("Enter your Last Name: ");
            string name = Console.ReadLine();
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name!");
            }
        }
    }
}
