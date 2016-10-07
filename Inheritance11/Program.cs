using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Year = 1989;
            Console.WriteLine(myCar.Year);

            Toyota myToyota = new Toyota();
            Console.WriteLine("What Country was your car manufactured in?");
            myToyota.Country = Console.ReadLine();

            Console.WriteLine(myToyota.Country);
            Console.ReadLine();


            
            
            
        }
    }
}
