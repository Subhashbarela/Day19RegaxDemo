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

            //Console.WriteLine("Enter your EmailId: ");
            // string name = Console.ReadLine();
           
            string name = "Subhash123@gmail.net";
            bool val = pattern.validate(name);

            if (val)
            {
                Console.WriteLine("Valid Email Name");
            }
            else
            {
                Console.WriteLine("Invalid Email Name!");
            }
        }
    }
}
