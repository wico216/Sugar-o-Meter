using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sugar_o_Meter
{
    class Program
    {
        static void Main(string[] args)
        {
            Readings read = new Readings();
            float Sugarlvl = 0;
            
            Console.WriteLine("Please enter your current blood sugar: \b");
            Sugarlvl = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Your sugar level is: " + Sugarlvl);
           

        }
    }
}
