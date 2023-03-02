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

           
           
            String pass = "Subhash54";
            bool val = pattern.validate(pass);

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
